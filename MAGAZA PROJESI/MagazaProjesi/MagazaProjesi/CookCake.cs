using System;
using System.Collections.Generic;
using System.Text;

namespace MagazaProjesi
{
    interface CookCake
    {
        List<Sales> Sales { get; set; }
        List<Product> Products { get; set; }


        public void AddNewProduct(string _codeProduct, string _nameProduct, float _priceProduct, float _countProduct, Category _category);
        public void RemoveProductbyCode(string _codeProduct);
        public void ChangeProductbyCode(string _codeProduct, string _newnameProduct, float _newpriceProduct, float _newcountProduct, Category _newcategory);

        public void ChangeProductName(string _codproduct, string name);
        public string ChangeName(string cod);
        public void ChangeProductPrice(string _codproduct, float _price);
        public float ChangePrice(string cod);
        public void ChangeProductCount(string _codproduct, float _count);
        public float ChangeCount(string cod);
        public void ChangeProductCategory(string cod, Category categories);
        public Category ChangeCategory(string cod);

        
               
            }
    }

