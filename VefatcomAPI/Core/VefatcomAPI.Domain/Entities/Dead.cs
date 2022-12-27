using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VefatcomAPI.Domain.Entities.Common;

namespace VefatcomAPI.Domain.Entities
{
    public class Dead : BaseEntity
    {
        public string DeadName { get; set; }
        public string DeadLastName { get; set; }
        public string DeadDate { get; set; } 
        public int DeadAge { get; set; }
        
        


    }
}
