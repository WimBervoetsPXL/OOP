using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Result
{
    public class DbResult : BaseResult<DataTable>
    {
        public int RowsAffected { get; set; }
    }
}
