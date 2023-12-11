using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Infrastucture.Data.Domain
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public virtual IEnumerable<Product> products { get; set; } = new List<Product>();
    }
}
