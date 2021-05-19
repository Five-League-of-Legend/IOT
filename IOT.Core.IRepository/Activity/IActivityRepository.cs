using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Activity
{
    public interface IActivityRepository
    {
        //添加
        int AddActivity(IOT.Core.Model.Activity a);

        //显示
        List<IOT.Core.Model.Activity> ShowActivity();

        //删除
        int DelActivity(string id);

        //修改
        int UptActivity(IOT.Core.Model.Activity a);
    }
}
