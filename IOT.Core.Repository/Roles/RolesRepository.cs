using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOT.Core.Common;
using IOT.Core.IRepository.Roles;

namespace IOT.Core.Repository.Roles
{
    public class RolesRepository : IRolesRepository
    {
        public int AddRoles(Model.Roles a)
        {
            string sql = $"insert into Roles values (null,'{a.RoleName}')";
            return DapperHelper.Execute(sql);
        }

        public int DelRoles(string id)
        {
            string sql = $"delete from Roles where RoleId={id}";
            return DapperHelper.Execute(sql);
        }

        public List<Model.Roles> ShowRoles()
        {
            string sql = "select * from Roles";
            return DapperHelper.GetList<Model.Roles>(sql);
        }

        public int UptRoles(Model.Roles a)
        {
            string sql = $"update  Roles  set  RoleName='{a.RoleName}' where RoleId={a.RoleId})";
            return DapperHelper.Execute(sql);
        }
    }
}
