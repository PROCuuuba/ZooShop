using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
