using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public class GenericPairResponse<T, U>
    {
        public T Key { get; set; } 
        public U Value { get; set; }
    }
}
