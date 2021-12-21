﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void Display(List<ProductReview> ProductReviewlist)
        {
            foreach (var item in ProductReviewlist)
            {
                Console.WriteLine("ProductId:" + item.ProductID + " " + "UserID:" + item.UserID + " " + "Rating:" + item.Rating + " " + "Review:" + item.Review + " " + "isLike:" + item.isLike);
            }
        }
        public void SelectTopThreeRecords(List<ProductReview> ProductReviewlist)
        {
            var records = (from product in ProductReviewlist orderby product.Rating descending select product).Take(3).ToList();
            Display(records);
        }
        public void RetrieveRecordsUsingRatingAndProductId(List<ProductReview> ProductReviewlist)
        {
            var records = (from Product in ProductReviewlist where (Product.ProductID == 1 || Product.ProductID == 4 || Product.ProductID == 9) && Product.Rating > 3 select Product).ToList();
            Display(records);
        }
        public void RetrieveCountOfRecords(List<ProductReview> ProductReviewlist)
        {
            var records = ProductReviewlist.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var item in records)
            {
                Console.WriteLine(item.ProductID + "-----"+ item.Count);
            }
        }
        public void RetrieveProductIdAndReview(List<ProductReview> ProductReviewlist)
        {
            var records = from productReview in ProductReviewlist
                          select new { productReview .ProductID, productReview.Review };
            foreach (var list in records)
            {
                Console.WriteLine("ProductId :"+ list.ProductID + " " + "Review :" + list.Review);
            }
        }
    }
}
