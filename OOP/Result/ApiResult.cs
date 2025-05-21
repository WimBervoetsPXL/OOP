using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Result
{
    public class ApiResult<T> : BaseResult<T>
    {
        public int StatusCode { get; set; } //200, 400, 500
    }
}
