using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MagazaProjesi
{
    class SaleItem
    {
        private static int _totalNo;
        private int _no { get; set; }
        public int No { get => _no; }
        public Product Products { get; set; }
        public int Count { get; set; }

        public SaleItem(Product product)
        {

            _totalNo++;
            _no = _totalNo - 1;

            this.Products = product;
        }
    }
}
    
        
    