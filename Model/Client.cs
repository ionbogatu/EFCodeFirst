using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.Model
{
    public partial class Client
    {
        public int ClientId { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(50)] 
        public string Email { get; set; }
     
        public ICollection<Order> Orders { get; set; }
        
        protected Client() {}
    }
}
