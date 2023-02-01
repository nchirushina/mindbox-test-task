namespace MindboxDb
{
    public static class DapperQueryStrings
    {
        public static string GetProducts = @"
SELECT [t_products].[Id] AS ProductId
      ,[t_products].[name] AS ProductName
      ,[t_categories].[Id] AS CategoryId
	  ,[t_categories].[name] AS CategoryName
  FROM [MindboxDb].[dbo].[t_products]
  LEFT JOIN [MindboxDb].[dbo].[CategoryProduct]
  ON [CategoryProduct].ProductsId = [t_products].Id
	LEFT JOIN [MindboxDb].[dbo].[t_categories]
	ON [CategoryProduct].CategoriesId = [t_categories].Id";
    }
}
