using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management Using LINQ");
            //UC1
            List<ProductReview> ProductReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 3, Review = "Very Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 2, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 4, Rating = 3, Review = "Very Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 5, Rating = 1, Review = "Ok", isLike = false },
                new ProductReview() { ProductID = 6, UserID = 6, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 7, Rating = 1, Review = "Ok", isLike = false },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 9, Rating = 4, Review = "Superb", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 5, Review = "Outstanding", isLike = true }
            };
            /*foreach (var item in ProductReviewlist)
            {
                Console.WriteLine("ProductId:" + item.ProductID + " " + "UserID:" + item.UserID + " " + "Rating:" + item.Rating + " " + "Review:" + item.Review + " " + "isLike:" + item.isLike);
            }*/
            Management manage = new Management();
            //UC2
            //manage.SelectTopThreeRecords(ProductReviewlist);
            //UC3
            //manage.RetrieveRecordsUsingRatingAndProductId(ProductReviewlist);
            //UC4
            //manage.RetrieveCountOfRecords(ProductReviewlist);
            //UC5
            manage.RetrieveProductIdAndReview(ProductReviewlist);
        }
    }
}