namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, UserId = 1, Rating = 5, Review = "Very Good", IsLike = true },
                new Product { ProductId = 2, UserId = 2, Rating = 4, Review = "Good", IsLike = true },
                new Product { ProductId = 3, UserId = 3, Rating = 2, Review = "Bad", IsLike = false },
                new Product { ProductId = 4, UserId = 4, Rating = 4, Review = "Good", IsLike = true },
                new Product { ProductId = 3, UserId = 5, Rating = 2, Review = "Bad", IsLike = false },
                new Product { ProductId = 4, UserId = 5, Rating = 3, Review = "Very Good", IsLike = true },
                new Product { ProductId = 2, UserId = 4, Rating = 4, Review = "Good", IsLike = true },
                new Product { ProductId = 1, UserId = 3, Rating = 1, Review = "Very Bad", IsLike = false },
                new Product { ProductId = 4, UserId = 2, Rating = 2, Review = "Bad", IsLike = false },
                new Product { ProductId = 2, UserId = 1, Rating = 4, Review = "Good", IsLike = true },
                new Product { ProductId = 1, UserId = 4, Rating = 5, Review = "Very Good", IsLike = true },
                new Product { ProductId = 3, UserId = 2, Rating = 2, Review = "Bad", IsLike = false },
                new Product { ProductId = 2, UserId = 1, Rating = 3, Review = "Very Good", IsLike = true },
                new Product { ProductId = 1, UserId = 3, Rating = 5, Review = "Very Good", IsLike = true },
                new Product { ProductId = 2, UserId = 5, Rating = 2, Review = "Bad", IsLike = false },
                new Product { ProductId = 2, UserId = 2, Rating = 3, Review = "Very Good", IsLike = true },
                new Product { ProductId = 1, UserId = 1, Rating = 4, Review = "Good", IsLike = true },
                new Product { ProductId = 4, UserId = 5, Rating = 5, Review = "Very Good", IsLike = true },
                new Product { ProductId = 3, UserId = 4, Rating = 5, Review = "Very Good", IsLike = true },
                new Product { ProductId = 3, UserId = 3, Rating = 3, Review = "Very Good", IsLike = true },
                new Product { ProductId = 2, UserId = 3, Rating = 4, Review = "Good", IsLike = true },
                new Product { ProductId = 4, UserId = 2, Rating = 4, Review = "Good", IsLike = true },
                new Product { ProductId = 1, UserId = 7, Rating = 2, Review = "Bad", IsLike = false },
                new Product { ProductId = 1, UserId = 5, Rating = 1, Review = "Very Bad", IsLike = false },
                new Product { ProductId = 2, UserId = 1, Rating = 3, Review = "Very Good", IsLike = true }
            };
            Console.WriteLine("ProductId | UserId | Rating | Review");
            foreach ( var a in products)
            {
                Console.WriteLine("   " + a.ProductId + "      |   " + a.UserId + "    |   " + a.Rating + "    | " + a.Review);
            }
        }
    }
}