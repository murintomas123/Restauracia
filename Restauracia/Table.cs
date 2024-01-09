using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracia
{
    internal class Table
    {
       public int ID { get; set; }

       public int Numberofchairs { get; set; }
         public bool IsOccupied { get; set; }

        public Table(int iD, int numberofchairs)
        {
            ID = iD;
            Numberofchairs = numberofchairs;
        }

    }
}
