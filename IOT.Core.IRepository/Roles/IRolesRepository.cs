using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Roles
{
    public interface IRolesRepository
    {
        //添加
        int AddRoles(IOT.Core.Model.Roles a);

        //显示
        List<IOT.Core.Model.Roles> ShowRoles();

        //删除
        int DelRoles(string id);

        //修改
        int UptRoles(IOT.Core.Model.Roles a);
    }
}
