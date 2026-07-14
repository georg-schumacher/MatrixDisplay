using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixDisplay
{
    public class Buchstaben
    {
        public static byte BUCHSTABENBREITE = 7;
        //TODO private / Getmethode
        public bool[,] buchstabe_a = new bool[,]
        {
            {false, true,  true,  true,  true,  false,false },
            {true,  false, false, false, false, true, false  },
            {true,  false, false, false, false, true, false  },
            {true,  true,  true,  true,  true,  true, false  },
            {true,  false, false, false, false, true, false  },
            {true,  false, false, false, false, true, false  },
            {true,  false, false, false, false, true, false  },
            {true,  false, false, false, false, true, false  }
        };
        public bool[,] buchstabe_b = new bool[,]
        {
            { true,  true,  true,  true,  true,  false },
            { true,  false, false, false, false, true  },
            { true,  false, false, false, false, true  },
            { true,  true,  true,  true,  true,  false },
            { true,  false, false, false, false, true  },
            { true,  false, false, false, false, true  },
            { true,  false, false, false, false, true  },
            { true,  true,  true,  true,  true,  false }
        };

    }
}
