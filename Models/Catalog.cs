using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Catalog
    {
        public Catalog()
        {
            posts = new List<Post>();
        }
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public virtual ICollection<Post> posts { get; set; }

    }
}
