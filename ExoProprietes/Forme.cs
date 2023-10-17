using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoProprietes
{
    internal class Forme
    {
        public string Couleur { get; set; }

        public virtual double Perimetre
        {
            get { return 0; }
        }

        public virtual double Surface
        {
            get { return 0; }
        }
    }
}
