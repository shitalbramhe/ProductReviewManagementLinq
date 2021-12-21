﻿using System;
using System.Collections.Generic;
using System.Data;
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
                Console.WriteLine(item.ProductID + "-----" + item.Count);
            }
        }
        public void RetrieveProductIdAndReview(List<ProductReview> ProductReviewlist)
        {
            var records = from productReview in ProductReviewlist
                          select new { productReview.ProductID, productReview.Review };
            foreach (var list in records)
            {
                Console.WriteLine("ProductId :" + list.ProductID + " " + "Review :" + list.Review);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> ProductReviewlist)
        {
            var records = (from product in ProductReviewlist orderby product.Rating descending select product).Skip(5).ToList();
            Display(records);
        }

        DataTable dataTable = new DataTable();
        public void ProductReviewDataTable(List<ProductReview> ProductReviewlist)
        {
            dataTable.Columns.Add("ProductId").DataType = typeof(Int32);
            dataTable.Columns.Add("UserId").DataType = typeof(Int32);
            dataTable.Columns.Add("Rating").DataType = typeof(Int32);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike").DataType = typeof(bool);
            foreach (var item in ProductReviewlist)
            {
                dataTable.Rows.Add(item.ProductID, item.UserID, item.Rating, item.Review, item.isLike);
            }
            var productTable = from products in dataTable.AsEnumerable() select products;
            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserId") + " " + product.Field<int>("Rating") + " " + product.Field<string>("Review") + " " + product.Field<bool>("isLike"));
            }
        }
       
    }
}

