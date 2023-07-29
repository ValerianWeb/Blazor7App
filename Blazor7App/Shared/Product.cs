using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor7App.Shared
{
    public enum ProductCategories
    {
        None,
        Books, 
        Electronics,
        Groceries,
        Home,
        Toys,
        Clothing
    }

    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public ProductCategories Category { get; set; } = ProductCategories.None;

        public string Image { get; set; } = "";

        public decimal Price { get; set; } = 0;
    }
}
