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
                               where (reviewList.Rating > 3 && (reviewList.ProductId == 1 || reviewList.ProductId == 4 || reviewList.ProductId == 9))
                               select reviewList);
            Console.WriteLine("ProductId | UserId | Rating | Review    | IsLike");
            foreach (var list in productdata)
            {
                Console.WriteLine("    " + list.ProductId + "     |   " + list.UserId + "    |   " + list.Rating + "    | " + list.Review + " | " + list.IsLike);
            }
        }
        public static void Count(List<Product> productReviewList)
        {
            var groupByProductId = (from reviewList in productReviewList
                               group reviewList by reviewList.ProductId into newGroup
                               orderby newGroup.Key
                               select new { ProductId = newGroup.Key, Count = newGroup.Count()}
                               );
            Console.WriteLine("ProductId | Count");
            foreach ( var a in groupByProductId ) 
            {
                Console.WriteLine($"    {a.ProductId}     |   {a.Count}");
            }
        }
    }
}
