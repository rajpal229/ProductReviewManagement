﻿namespace ProductReviewManagement
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
            Console.WriteLine("Enter\n1.For Top 3 Records\n2.For Count of ProductId");
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
                }
                break;
            }
        }
    }
}