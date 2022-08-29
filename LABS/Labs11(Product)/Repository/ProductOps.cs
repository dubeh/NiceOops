using Labs11_Product_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labs11_Product_.Repository
{
    public class ProductOps
    {
        private readonly static List<Product> prods = new List<Product>();

        public List<Product> GetAll()
        {

            if (prods.Count == 0)

            {
                prods.Add(new Product() { Roles = new string[] { "Admin" }, ID = 2, Price = 22, Name = "qwerty", Category = "rty" });
                prods.Add(new Product() { Roles = new string[] { "User" }, ID = 1, Price = 22, Name = "qwerty", Category = "qwe" });
            }
            
            return prods;
        }

        public bool Update(int id, Product uProd)
        {
            Product Found = Find(id);
            if (Found != null)
            {
                Found.Category = uProd.Category;
                Found.Name = uProd.Name;
                Found.Price = uProd.Price;
                return true;
            }
            throw new Exception("User Not Found");
        }

        public Product Find(int id)
        {
            return prods.Find(x => x.ID == id);
        }

        public bool Delete(Product uProd)
        {
            prods.Remove(prods.Find(user => user.Name == uProd.Name));
            return true;

        }

        public void Add(Product uProd)
        {
            prods.Add(uProd);
        }

        /*public List<Product> GetByCategory(string category)
        {
          //  List<Product> pro = prods.Where((m) => { return m.Category == category; });
            
            return pro;
        }*/
    }
}