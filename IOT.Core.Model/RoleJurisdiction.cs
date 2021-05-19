using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 角色权限
    /// </summary>
    public class RoleJurisdiction
    {
        public int RoleId { get; set; }//角色外键
        public int JurisdictionId { get; set; }//权限外键
    }
}
