using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 团长管理
    /// </summary>
    public class ColonelManagement
    {
        public int CMId         { get; set; }
        public int ColonelID    { get; set; }
        public string CheckName    { get; set; }
        public DateTime AapplyTime   { get; set; }
        public DateTime CheckTime    { get; set; }
        public int CheckStatus  { get; set; }
    }
}
