using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 配送小区
    /// </summary>
    public class Delivery
    {
        public int DeliveryId   { get; set; }
        public int UserId       { get; set; }
        public int ColonelID    { get; set; }
        public string DeliveryPath { get; set; }
        public string DeliveryName { get; set; }
    }
}
