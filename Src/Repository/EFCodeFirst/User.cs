using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.EFCodeFirst
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }
        [StringLength(64)]
        [Required]
        public string UserName { get; set; }
        [MaxLength(64)]
        [Required]
        public string Pwd { get; set; }
        public int UserType { get; set; }
        public string Email { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateIp { get; set; }
        public DateTime Modify { get; set; }
        public string Other1 { get; set; }

        //public ICollection<Order> Orders { get; set; }
    }
}
