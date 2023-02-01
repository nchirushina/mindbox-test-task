namespace MindboxDb.QueryResults
{
    public class ProductsWithCategories
    {
        public Guid? ProductId { get; set; }

        public string ProductName { get; set; }

        public Guid? CategotyId { get; set; }

        public string CategoryName { get; set; }
    }
}
