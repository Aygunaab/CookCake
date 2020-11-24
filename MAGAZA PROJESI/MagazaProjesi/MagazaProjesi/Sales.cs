using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace MagazaProjesi
{
    class Sales
    {
        private static int _totalNo;
        private int _no;
        public float No { get => _no; }
        public double TotalAmount { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        public DateTime SaleDate { get; set; }

        public Sales(List<SaleItem> salesItems)
        {
            _totalNo++;
            _no = _totalNo;

            SaleItems = new List<SaleItem>();
            SaleItems = salesItems;
            SaleDate = DateTime.Now;

            foreach (var item in salesItems)
            {
                TotalAmount += item.Count * item.Products.PriceProduct;
            }
        }

        public Sales()
        {
        }
    }
}
