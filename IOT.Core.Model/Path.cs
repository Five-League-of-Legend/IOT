using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 路线
    /// </summary>
    public class Path
    {
        public int RathID            { get; set; }
        public string PathName          { get; set; }
        public string PName             { get; set; }
        public string Phone             { get; set; }
        public string WarehouseAddress  { get; set; }
        public string LongAndLat        { get; set; }
        public int ColonelNum        { get; set; }
        public int State             { get; set; }
    }
}
