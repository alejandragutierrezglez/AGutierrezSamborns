using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult GetAll(ML.Orders orders)
        {
            ML.Result result = BL.Northwind.ClienteOrderCustomerGetAll(orders);

            orders = new ML.Orders();
            if (result.Correct)
            {
                orders.Orderes = result.Objects;
                return View(orders);
            }
            else
            {
                return View(orders);
            }
        }
        public IActionResult ProductosDescontinuadosGetAll(ML.Product product)
        {
            ML.Result result = BL.Northwind.ProductosDescontinuados(product);

            product = new ML.Product();
            if (result.Correct)
            {
                product.Products = result.Objects;
                return View(product);
            }
            else
            {
                return View(product);
            }
        }
        public IActionResult ProductosPrecioUnitarioPromedioGetAll(ML.Product product)
        {
            ML.Result result = BL.Northwind.ProductosPrecioUnitarioPromedio(product);

            product = new ML.Product();
            if (result.Correct)
            {
                product.Products = result.Objects;
                return View(product);
            }
            else
            {
                return View(product);
            }
        }
    }

}
