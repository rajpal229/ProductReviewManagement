namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product {SRNumber =1, ProductId = 1, UserId = 1, Rating = 5, Review = "Very Good", IsLike = true },
                new Product {SRNumber =2, ProductId = 2, UserId = 2, Rating = 4, Review = "Good", IsLike = true },
                new Product {SRNumber =3, ProductId = 3, UserId = 3, Rating = 2, Review = "Bad", IsLike = false },
                new Product {SRNumber =4, ProductId = 4, UserId = 4, Rating = 4, Review = "Good", IsLike = true },
                new Product {SRNumber =5, ProductId = 3, UserId = 5, Rating = 2, Review = "Bad", IsLike = false },
                new Product {SRNumber =6, ProductId = 4, UserId = 5, Rating = 3, Review = "Fair", IsLike = true },
                new Product {SRNumber =7, ProductId = 2, UserId = 4, Rating = 4, Review = "Good", IsLike = true },
                new Product {SRNumber =8, ProductId = 1, UserId = 3, Rating = 1, Review = "Very Bad", IsLike = false },
                new Product {SRNumber =9, ProductId = 4, UserId = 2, Rating = 2, Review = "Bad", IsLike = false },
                new Product {SRNumber =10, ProductId = 2, UserId = 1, Rating = 4, Review = "Good", IsLike = true },
                new Product {SRNumber =11, ProductId = 1, UserId = 4, Rating = 5, Review = "Very Good", IsLike = true },
                new Product {SRNumber =12, ProductId = 3, UserId = 2, Rating = 2, Review = "Bad", IsLike = false },
                new Product {SRNumber =13, ProductId = 2, UserId = 1, Rating = 3, Review = "Fair", IsLike = true },
                new Product {SRNumber =14, ProductId = 1, UserId = 3, Rating = 5, Review = "Very Good", IsLike = true },
                new Product {SRNumber =15, ProductId = 2, UserId = 5, Rating = 2, Review = "Bad", IsLike = false },
                new Product {SRNumber =16, ProductId = 2, UserId = 2, Rating = 3, Review = "Fair", IsLike = true },
                new Product {SRNumber =17, ProductId = 1, UserId = 1, Rating = 4, Review = "Good", IsLike = true },
                new Product {SRNumber =18, ProductId = 4, UserId = 5, Rating = 5, Review = "Very Good", IsLike = true },
                new Product {SRNumber =19, ProductId = 3, UserId = 4, Rating = 5, Review = "Very Good", IsLike = true },
                new Product {SRNumber =20, ProductId = 3, UserId = 3, Rating = 3, Review = "Fair", IsLike = true },
                new Product {SRNumber =21, ProductId = 2, UserId = 3, Rating = 4, Review = "Good", IsLike = true },
                new Product {SRNumber =22, ProductId = 4, UserId = 2, Rating = 4, Review = "Good", IsLike = true },
                new Product {SRNumber =23, ProductId = 1, UserId = 7, Rating = 2, Review = "Bad", IsLike = false },
                new Product {SRNumber =24, ProductId = 1, UserId = 5, Rating = 1, Review = "Very Bad", IsLike = false },
                new Product {SRNumber =25, ProductId = 2, UserId = 1, Rating = 3, Review = "Fair", IsLike = true }
            };
            Console.WriteLine("Enter\n1.For Top 3 Records\n2.For Count of ProductId\n3.Retrieve Only ProductId and Review\n4.Skip first 5 Records");
            int op = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (op)
                {
                    case 1:
                        ProductReviewManagement.Top3Records(products);

                        break;
                    case 2:
                        ProductReviewManagement.Count(products);
                        break;
                    case 3:
                        ProductReviewManagement.RetrieveOnly(products);
                        break;
                    case 4:
                        ProductReviewManagement.Skip5Records(products);
                        break;
                }
                break;
            }
        }
    }
}