using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { set; get; }
        [StringLength(50)]

        public string UserName { set; get; }
        [StringLength(50)]

        public string UserMail { set; get; }
        [StringLength(50)]

        public string Subject { set; get; }
        public string Message { set; get; }
    }
}
