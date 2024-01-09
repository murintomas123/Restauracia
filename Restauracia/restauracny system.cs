using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracia
{
    internal class Restauracny_system
    {
        List<Table> Tables { get; set; } = new List<Table>();   
         public void AddTable(Table table)
        {
            Tables.Add(table);
        }
        public void RemoveTable(Table table)
        {
            Tables.Remove(table);
        }


    }

  
}
