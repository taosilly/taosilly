using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Contact:DbSetBase
    {
        [StringLength(10)]
        public string UserName{set;get;}
        
        [DataType(DataType.EmailAddress)]
        public string Email{set;get;}

         
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber{set;get;}

        [Required]
        [DataType(DataType.MultilineText)]
        public string Message{set;get;}

        
        [DataType(DataType.Date)]
        public DateTime SendDate{set;get;}
    }
}
