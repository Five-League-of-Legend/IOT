using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 订单评论
    /// </summary>
    public class OrderComment
    {
        public int Commentid     { get; set; }
        public int State         { get; set; }
        public int Com_CommentId { get; set; }
    }
}
