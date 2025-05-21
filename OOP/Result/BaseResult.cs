using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Result
{
    public abstract class BaseResult<T>
    {
        public bool IsSucces { get; set; }

        public T Result { get; set; }
    }
}
