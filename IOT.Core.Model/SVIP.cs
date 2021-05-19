using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 超级会员
    /// </summary>
     public  class SVIP
    {
        public int SId            { get; set; }
        public string  SName          { get; set; }
        public string BackgroudColor { get; set; }
        public string Icon           { get; set; }
        public string BCImg          { get; set; }
        public int Consume        { get; set; }
        public int Commission     { get; set; }
        public int Money          { get; set; }
        public string Rate           { get; set; }
        public string Explains { get; set; }
    }
}
