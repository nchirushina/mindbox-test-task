using Dapper;
using Microsoft.Data.SqlClient;
using MindboxDb.QueryResults;

namespace MindboxDb.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string connectionString;

        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<IEnumerable<ProductsWithCategories>> GetAllProductsAsync()
        {
            using (var db = new SqlConnection(this.connectionString))
            {
                var allProductsWithCategories = await db
                    .QueryAsync<ProductsWithCategories>(
                    DapperQueryStrings.GetProducts);

                return allProductsWithCategories;
            }
        }
    }
}
