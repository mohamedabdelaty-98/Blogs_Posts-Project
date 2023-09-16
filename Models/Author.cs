using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task2.Models
{
    public class Author
    {
        public Author()
        {
            posts = new List<Post>();

        }
        public int ID { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength (50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public int Age { get; set; }
        [Column(TypeName = "varbinary(max)")]
        public byte[] Photo { get; set; }
        public virtual ICollection<Post>? posts { get; set; }
    }
}
