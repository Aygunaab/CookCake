using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MagazaProjesi
{
    enum Category { CAKES, COOKIES, ECLAIRS, NATIONALSWEETS, PIES }
    class Product
    {
        public string codeProduct { get; set; }
        public string NameProduct { get; set; }
        public float PriceProduct { get; set; }
        public float countProduct { get; set; }
        public Category category { get; set; }



        public List<Product> Products = new List<Product>();


        public void AddNewProduct(string _codeProduct, string _nameProduct, float _priceProduct, float _countProduct, Category _category)
        {
            Product pr = new Product();


            pr.codeProduct = _codeProduct;
            pr.NameProduct = _nameProduct;
            pr.PriceProduct = _priceProduct;
            pr.countProduct = _countProduct;
            pr.category = _category;

            Products.Add(pr);

        }

        public void RemoveProductbyCode(string _codeProduct)
        {

            Product prnew = Products.FirstOrDefault((Product x) => x.codeProduct == _codeProduct);

            if (prnew != null)
            {
                Products.Remove(prnew);
            }
            else { Console.WriteLine("Bele mal yoxdur"); }
        }
        public void ChangeProductbyCode(string _codeProduct, string _newnameProduct, float _newpriceProduct, float _newcountProduct, Category _newcategory)
        {

            Product prnew = Products.FirstOrDefault((Product x) => x.codeProduct == _codeProduct);


            if (prnew != null)
            {
                Products.Remove(prnew);

                AddNewProduct(_codeProduct, _newnameProduct, _newpriceProduct, _newcountProduct, _newcategory);
            }
            else { Console.WriteLine("Bele mal yoxdur"); }
        }
        public void ChangeProductName(string _codproduct, string name)
        {
            Product product = Products.Find(pr => pr.codeProduct == _codproduct);
            if (product != null)
                product.NameProduct = name;

        }
        public string ChangeName(string cod)
        {
            Product product = Products.Find(p => p.codeProduct == cod);
            string name = product.NameProduct;
            return name;

        }

        public void ChangeProductPrice(string _codproduct, float _price)
        {
            Product product = Products.Find(pr => pr.codeProduct == _codproduct);
            if (product != null)
                product.PriceProduct = _price;

        }
        public float ChangePrice(string cod)
        {
            Product product = Products.Find(p => p.codeProduct == cod);
            float price = product.PriceProduct;
            return price;
        }

        public void ChangeProductCount(string _codproduct, float _count)
        {
            Product product = Products.Find(pr => pr.countProduct == _count);
            if (product != null)
                product.countProduct = _count;

        }
        public float ChangeCount(string cod)
        {
            Product product = Products.Find(p => p.codeProduct == cod);
            float count = product.countProduct;
            return count;
        }
        public void ChangeProductCategory(string cod, Category categories)
        {
            Product product = Products.Find(p => p.codeProduct == cod);
            if (product != null)
                product.category = categories;


        }

        public Category ChangeCategory(string cod)
        {
            Product product = Products.Find(p => p.codeProduct == cod);
            Category categories = product.category;
            return categories;
        }
       
    }
    }
