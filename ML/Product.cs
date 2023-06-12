namespace ML
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public ML.Suppliers Supplier { get; set; }
        public ML.Categories Categories { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }
        public decimal PromedioPrecioUnitario { get; set; }
        public List<object> Products { get; set; }
    }
}