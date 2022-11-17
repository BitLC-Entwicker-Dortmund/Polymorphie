using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie {
    class Gehege {
        private List<Tier> tiere = new List<Tier> ( );

        internal void AddTier ( Tier tier ) {
            tiere.Add ( tier);
        }

        internal void ZeigeTiere ( ) {
            foreach ( Tier einTier in tiere ) {
                einTier.MachWas ( );
                
            }
        }
    }
}
