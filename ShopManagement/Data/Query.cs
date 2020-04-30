using ShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement.Data
{
    public class Query
    {
        private ShopContext shopContext { get; set; }
        //Check dbconnection and connect to database
        public Query()
        {
            if (!DbConnection.CheckDbConnection())
            {
                MessageBox.Show("Connection Failed. Call to IT");
                Application.Exit();
            }
            else
            {
                shopContext = new ShopContext();
            }
        }
         ~Query()
        {
            shopContext.Dispose();
        }

        //Return user id using login and password comparison
        public int GetIdEmployee(string login, string password)
        {
            var idEmployee = shopContext.Users
                .Where(x => (x.Login == login) && (x.Password == password))
                .Select(x => x.Idemployee).FirstOrDefault();

            return idEmployee;
        }

        public bool ExistsProduct(int Idproduct)
        {
            return shopContext.Products.Join(shopContext.Categories, x => x.Idcategory, y => y.Idcategory, (x, y) => new
                    {
                        Discount = x.Discount,
                        Vat = x.IdcategoryNavigation.Vat,
                        Idproduct = x.Idproduct,
                        Idcategory = x.Idcategory,
                        ProductName = x.ProductName,
                        UnitPrice = x.UnitPrice,
                        UnitQuantity = x.UnitQuantity,
                    })
                        .Where(x => x.Idproduct == Idproduct).Any();
        }

        //Returns product information from the list
        public ReceiptList GetProductInfo(int Idproduct)
        {
            var res = shopContext.Products.Join(shopContext.Categories, x => x.Idcategory, y => y.Idcategory, (x, y) => new
            {
                Discount = x.Discount,
                Vat = x.IdcategoryNavigation.Vat,
                Idproduct = x.Idproduct,
                Idcategory = x.Idcategory,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitQuantity = x.UnitQuantity,
            })
                .Where(x => x.Idproduct == Idproduct);

            ReceiptList receiptLists = new ReceiptList();
            foreach (var item in res)
            {
                receiptLists.Discount = item.Discount;
                receiptLists.Idcategory = item.Idcategory;
                receiptLists.Idproduct = item.Idproduct;
                receiptLists.ProductName = item.ProductName;
                receiptLists.UnitPrice = Math.Round(item.UnitPrice,2);//Because in database i have type money which is not rounded to two places after pointer
                receiptLists.UnitQuantity = item.UnitQuantity;
                receiptLists.Vat = item.Vat;
            }
            return receiptLists;
        }

        public void AddOrderToDatabase(List<ReceiptList> receiptLists, int idEmployee)
        {
            CreateOrder(idEmployee);

            int idOrder = GetIdOrder(idEmployee);

            CreateOrderPositions(idOrder, receiptLists);

            TakeOffStates(receiptLists);
        }
        //Add to table Orders rows Idemployee and SellDate. IdOrder has identity(1,1)
        private void CreateOrder(int idEmployee)
        {
            Orders order = new Orders();

            order.Idemployee = idEmployee;
            order.SellDate = DateTime.Now;

            shopContext.Orders.Add(order);
            shopContext.SaveChanges();
        }
        //Return last order created by the specified user
        public int GetIdOrder(int idEmployee)
        {
            int idOrder = shopContext.Orders.Where(x => x.Idemployee == idEmployee).Select(x => x.Idorder).ToList().Last();

            return idOrder;
        }
        public List<OrderDetails> GroupProductList(int idOrder, List<ReceiptList> receiptLists)
        {
            //Get items from list
            var groupedReceiptItems = receiptLists.GroupBy(x => new
            {
                x.Idproduct,
                x.UnitPrice,
                x.Vat,
                x.Discount
            });

            //Collection that will be use to make insert query
            List<OrderDetails> orderDetailsList = new List<OrderDetails>();

            OrderDetails orderDetails;

            foreach (var product in groupedReceiptItems)
            {
                orderDetails = new OrderDetails();

                orderDetails.Idorder = idOrder;
                orderDetails.Idproduct = product.Key.Idproduct;
                orderDetails.UnitPrice = product.Key.UnitPrice;
                orderDetails.Vat = product.Key.Vat;
                orderDetails.Discount = product.Key.Discount;

                orderDetails.Quantity = 0;

                foreach (var quan in product)
                {
                    orderDetails.Quantity += quan.Quantity;
                }

                orderDetailsList.Add(orderDetails);
            }

            return orderDetailsList;
        }
        private void CreateOrderPositions(int idOrder, List<ReceiptList> receiptLists)
        {
            List<OrderDetails> orderDetailsList = GroupProductList(idOrder, receiptLists);

            foreach (var item in orderDetailsList)
            {
                shopContext.OrderDetails.Add(item);
            }

            shopContext.SaveChanges();
        }
        private void TakeOffStates(List<ReceiptList> groupedReceiptLists) 
        {
            foreach (var item in groupedReceiptLists)
            {
                var product = shopContext.Products.SingleOrDefault(x => x.Idproduct == item.Idproduct);
                product.InventoryState -= item.Quantity;
                shopContext.SaveChanges();
            }
        }

        public string GetProductName(int idProduct)
        {
            return shopContext.Products.Where(x => x.Idproduct == idProduct).Select(x => x.ProductName).ToList().Last();
        }

        public void InsertDelivery(int idProduct, int quantity)
        {

            var states = shopContext.Products.SingleOrDefault(x => x.Idproduct == idProduct);

            states.InventoryState += quantity;
            
            shopContext.SaveChanges();
        }

        public Employees GetEmployeeById(int idEmployee)
        {
            return shopContext.Employees.Where(x => x.Idemployee == idEmployee).SingleOrDefault();
        }
        public void SignUpEmployee(string name, string surname, DateTime birthDate, string address,
                                   string zipcode, string city, string phoneNumber, string region,
                                   string position, DateTime employmentDate, int chief, string comment, byte[] imagePath)
        {
            Employees employee = new Employees();

            employee.Name = name;
            employee.Surname = surname;
            employee.BirthDate = birthDate;
            employee.Address = address;
            employee.ZipCode = zipcode;
            employee.City = city;
            employee.PhoneNumber = phoneNumber;
            employee.Region = region;
            employee.Position = position;
            employee.EmploymentDate = employmentDate;
            employee.Chief = chief;
            employee.Comments = comment;
            employee.Photo = imagePath;

            shopContext.Employees.Add(employee);
            shopContext.SaveChanges();
        }

        public string GetWorkPosition(int idEmployee)
        {
            return shopContext.Employees.SingleOrDefault(x => x.Idemployee==idEmployee).Position;
        }

        public void SaveProductInDB(Products product)
        {
            shopContext.Products.Add(product);
            shopContext.SaveChanges();
        }
    }
}
