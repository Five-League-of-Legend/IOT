using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 现有库存
    /// </summary>
    public class NowRep
    {
        public int NowRepId     { get; set; }
        public int CommodityId  { get; set; }
        public int WarehouseId  { get; set; }
        public int PutLibraryId { get; set; }
        public int OutLibraryId { get; set; }
    }
}
