using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriasFarm.Models {
    public class DiaHistorial {
        public DateTime Dia { get; set; }
        public Dictionary<string,int>? CausaYCaloriasList { get; set; }

    }
}
