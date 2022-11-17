using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie {
    class Program {
        static void Main ( string [ ] args ) {
            // Subtyp-Polymorphie: der Container nimmt alle Objekte auf
            ArrayList al = new ArrayList ( );
            al.Add ( "ein String");
            al.Add ( new Person());
            al.Add ( new Robert());

            Console.WriteLine ( al.Count);
            foreach ( object item in al ) {
                Console.WriteLine ( item );
            }
            // Parametrische Polymorphie
            List<Person> people = new List<Person> ( );

            people.Add ( new Person());
            people.Add ( new Person());
            people.Add ( new Robert());
            // Tier-Beispiel
            Gehege g1 = new Gehege ( );
            g1.AddTier ( new Tier ( ) );
            g1.AddTier ( new Edward ( ) );
            g1.AddTier ( new Ruslan ( ) );
            g1.ZeigeTiere ( );

            Console.ReadKey ( );
        }
    }

    class Person { }
    class Robert: Person { }
    class Tier {
        public void MachWas ( ) { Console.WriteLine ( "Gruß aus dem Gehege" ); }
    }
    class Edward : Tier { }
    class Ruslan : Tier { }
}
