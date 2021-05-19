using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class CommType
    {
        public int TId      { get; set; }
        public string TName    { get; set; }
        public int Sort     { get; set; }
        public string TIcon    { get; set; }
        public int State    { get; set; }
        public int ParentId { get; set; }
    }
}
