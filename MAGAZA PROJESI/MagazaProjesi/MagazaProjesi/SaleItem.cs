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
       public float _totalNo { get; set; }
       public float No { get; set; }
       public Product Products { get; set; }
       public int Count { get; set; }

        public SaleItem(Product product)
        {

            _totalNo++;
            No = _totalNo - 1;

            this.Products = product;
        }

        public SaleItem()
        {
        }
    }
}
    
        
    