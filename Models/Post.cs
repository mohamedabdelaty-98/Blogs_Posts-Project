using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Post
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Bref { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        
        public TimeSpan Time { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [ForeignKey("author")]
        public int Authoer_id { get; set; }
        [ForeignKey("catalog")]
        public int? Cat_id { get; set; }
        [Column(TypeName = "varbinary(max)")]
        public byte[] Photo { get; set; }
        public virtual Author author { get; set; }
        public virtual Catalog catalog { get; set; }

    }
}
