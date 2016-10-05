using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Blog:DbSetBase
    {

        [Required]
        public string Title{set;get;}

        [Required]
        public string Content{set;get;}

        [Required]
        [ForeignKey("Category")]
        public Guid CategoryId{set;get;}

        public string Tags{set;get;}

        public string Author{set;get;}

        [DataType(DataType.Date)]
        public DateTime CreateDate{set;get;}

        public Category BlogCategory{set;get;}
    }
}
