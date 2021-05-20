using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 角色管理
    /// </summary>
    public   class RoleManage
    {
        public int RMId { get; set; }
        public int RoleId { get; set; }//角色外键
        public string  HobOne { get; set; }
        public string HobTwo { get; set; }
        public string HobThree { get; set; }
        public string Four { get; set; }
    }
}
