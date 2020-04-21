using System;
using System.Collections.Generic;
using System.Text;

namespace gamelogic
{
    class territory
    {
        int units { set; get; } // antal units på feltet
        int husnr { set; get; } // id på territorie
        List<int> naboer { set; get; }// liste over felter der ligger op af.
        player ejer { set; get; }


        void place_units (territory t){	t.units++;}
        void allocate_territory(territory t) { }
    }
}
