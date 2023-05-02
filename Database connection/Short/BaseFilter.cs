using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Short
{
    public class BaseFilter
    {
        public int NumberPage { get; set; }

        public int Count { get; set; }

        public int MaxPage { get; set; }

        public BaseFilter() 
        {
        
        }
    }
}
