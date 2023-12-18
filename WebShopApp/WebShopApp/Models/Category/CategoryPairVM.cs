using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Category
{
    public class CategoryPairVM
    {
        public int Id { get; set; }
        [Display(Name ="Name")]
        public string Name { get; set; }
    }
}
