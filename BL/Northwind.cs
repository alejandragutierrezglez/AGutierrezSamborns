using DL;
using Microsoft.EntityFrameworkCore;
using ML;

namespace BL
{
    public class Northwind
    {
        public static ML.Result ClienteOrderCustomerGetAll(ML.Orders orders)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.NorthwindContext context = new DL.NorthwindContext())
                {
                    var query = context.Orders.FromSqlRaw($"ClienteOrderCustomerGetAll '{orders.OrderDate}'").ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            orders = new ML.Orders();
                            orders.OrderID = item.OrderId;
                            orders.OrderDate = item.OrderDate.Value.ToString("dd/MM/yyyy");

                            orders.Customers = new ML.Customers();
                            orders.Customers.CompanyName = item.CompañiaCliente;

                            orders.OrderDetails = new ML.OrderDetails();
                            orders.OrderDetails.Quantity = item.Quantity;

                            orders.OrderDetails.Product = new ML.Product();
                            orders.OrderDetails.Product.ProductName = item.ProductName;

                            orders.OrderDetails.Product.Supplier = new ML.Suppliers();
                            orders.OrderDetails.Product.Supplier.CompanyName = item.CompañiaProveedor;
                            orders.OrderDetails.Product.Supplier.City = item.CiudadProveedor;

                            result.Objects.Add(orders);
                            result.Correct = true;

                        }

                    }

                }
            }
            catch (Exception Ex)
            {
                result.Correct = true;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }

            return result;
        }

        public static ML.Result ProductosDescontinuados(ML.Product product)
        { 
            ML.Result result = new ML.Result();
            try
            {
                using (DL.NorthwindContext context = new DL.NorthwindContext())
                {
                    var query = context.Products.FromSqlRaw($"ProductosDescontinuados").ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            product = new ML.Product();
                            product.ProductID = item.ProductId;
                            product.ProductName = item.ProductName;
                            product.QuantityPerUnit = item.QuantityPerUnit;
                            product.UnitPrice = item.UnitPrice.Value;
                            product.UnitsInStock = item.UnitsInStock.Value;
                            product.UnitsOnOrder = item.UnitsOnOrder.Value;
                            product.ReOrderLevel = item.ReorderLevel.Value;
                            product.Discontinued= item.Discontinued;
                            product.PromedioPrecioUnitario = item.PromedioPrecioUnitario;


                            product.Supplier = new ML.Suppliers();
                            product.Supplier.SupplierID = item.SupplierId.Value;

                            product.Categories = new ML.Categories();
                            product.Categories.CategoryID= item.CategoryId.Value;
                            product.Categories.CategoryName = item.CategoryName;
                            

                            result.Objects.Add(product);
                            result.Correct = true;
                        }
                    
                    }
                
                }
            }
            catch (Exception Ex)
            {
                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }
            return result;
        }

        public static ML.Result ProductosPrecioUnitarioPromedio(ML.Product product)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.NorthwindContext context = new DL.NorthwindContext())
                {
                    var query = context.Products.FromSqlRaw($"ProductosPrecioUnitarioPromedio").ToList();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            product = new ML.Product();
                            product.ProductID = item.ProductId;
                            product.ProductName = item.ProductName;
                            product.QuantityPerUnit = item.QuantityPerUnit;
                            product.UnitPrice = item.UnitPrice.Value;
                            product.UnitsInStock = item.UnitsInStock.Value;
                            product.UnitsOnOrder = item.UnitsOnOrder.Value;
                            product.ReOrderLevel = item.ReorderLevel.Value;
                            product.Discontinued = item.Discontinued;
                            product.PromedioPrecioUnitario = item.PromedioPrecioUnitario;


                            product.Categories = new ML.Categories();
                            product.Categories.CategoryID = item.CategoryId.Value;
                            product.Categories.CategoryName = item.CategoryName;

                            result.Objects.Add(product);
                            result.Correct = true;
                        }

                    }

                }
            }
            catch (Exception Ex)
            {
                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }
            return result;
        }
    }
}