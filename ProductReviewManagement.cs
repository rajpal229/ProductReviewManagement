using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ProductReviewManagement
    {
        public static void Top3Records(List<Product> productReviewList)
        {
            var productdata = (from reviewList in productReviewList
                               where reviewList.Rating == 5
                               select reviewList).Take(3);
            Console.WriteLine("ProductId | UserId | Rating | Review    | IsLike");
            foreach (var list in productdata)
            {
                Console.WriteLine("    " + list.ProductId + "     |   " + list.UserId + "    |   " + list.Rating + "    | " + list.Review + " | " + list.IsLike);
            }
        }
    }
}
