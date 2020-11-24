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
        private object count;

        public Product(string nameProduct, float priceProduct, object count, string codeProduct, Category category)
        {
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
            this.count = count;
            this.codeProduct = codeProduct;
            this.category = category;
        }

        public Product()
        {
        }

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
        List<Sales> salelist = new List<Sales>();
        public void Addsale(Product products, int count)
        {

            Product product = new Product(products.NameProduct, products.PriceProduct, products.countProduct, products.codeProduct, products.category);
            if (count > 0 && Products.Exists(p => p.codeProduct == product.codeProduct))
            {
                SaleItem salesItems = new SaleItem(product) { Count = count };
                List<SaleItem> salesItemsList = new List<SaleItem>();
                salesItemsList.Add(salesItems);
                Sales sale = new Sales(salesItemsList) { SaleItems = salesItemsList, TotalAmount = product.PriceProduct * count };
                salelist.Add(sale);
                products.countProduct = products.countProduct - count;


            }
        }

        List<SaleItem> SalesitemList = new List<SaleItem>();
        public void AddItem(float _nom, int count, Product _product)
        {
            SaleItem sale = new SaleItem();
            _nom++;
            sale.Count = count;
            sale.Products = _product;

            SalesitemList.Add(sale);
        }

        public static Category CategorySetter(string category)
        {

            string categ = category;
            Category CategoryEnum = (Category)Convert.ToInt32(category);
            switch (categ)
            {
                case "1":
                    CategoryEnum = Category.CAKES;
                    break;
                case "2":
                    CategoryEnum = Category.COOKIES;
                    break;
                case "3":
                    CategoryEnum = Category.ECLAIRS;
                    break;
                case "4":
                    CategoryEnum = Category.NATIONALSWEETS;
                    break;
                case "5":
                    CategoryEnum = Category.PIES;
                    break;

                    break;
                default:
                    break;
            }
            return CategoryEnum;
        }
    }
}