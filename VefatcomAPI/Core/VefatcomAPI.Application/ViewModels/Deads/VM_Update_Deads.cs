using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VefatcomAPI.Application.ViewModels.Deads
{
    public class VM_Update_Deads
    {
        public string Id { get; set; }
        public string DeadName { get; set; }
        public string DeadUsername { get; set; }

        public string DeadDate { get; set; }
        public int DeadAge { get; set; }
    
    }
}
