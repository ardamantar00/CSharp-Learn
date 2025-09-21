using CSharpEgitimKampi301.DataAccsessLayer.Abstract;
using CSharpEgitimKampi301.DataAccsessLayer.Context;
using CSharpEgitimKampi301.DataAccsessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccsessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x=>new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName


            }).ToList();
            return values.Cast<Object>().ToList();
        }
    }
}
