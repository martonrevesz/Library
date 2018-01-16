using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int Fine { get; set; }
        public string UserType { get; set; }
        public bool VIP { get; set; }
        
    }
}
