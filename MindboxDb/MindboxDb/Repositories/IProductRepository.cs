using MindboxDb.QueryResults;

namespace MindboxDb.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// Запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно выводится.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ProductsWithCategories>> GetAllProductsAsync();
    }
}
