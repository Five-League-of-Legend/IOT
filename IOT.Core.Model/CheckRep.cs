using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 盘点库存
    /// </summary>
    public class CheckRep
    {
        public int CheckRepId   { get; set; }
        public string CheckNo      { get; set; }
        public int WarehouseId  { get; set; }
        public int CheckNum     { get; set; }
        public string CheckPeople  { get; set; }
        public DateTime CheckDate    { get; set; }
    }
}
