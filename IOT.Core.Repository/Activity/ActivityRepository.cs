using IOT.Core.Common;
using IOT.Core.IRepository.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Repository.Activity
{
    public class ActivityRepository : IActivityRepository
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int AddActivity(Model.Activity a)
        {
            string sql = $"insert into Activity values (null,'{a.ActivityName}', '{a.BeginTime}', '{a.EndTime}', '{a.Slideshow}', {a.State},'{a.CreateDate}', {a.ActivityTime})";
            return DapperHelper.Execute(sql);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelActivity(string id)
        {
            string sql = $"delete from Activity where ActivityId={id}";
            return DapperHelper.Execute(sql);
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Model.Activity> ShowActivity()
        {
            string sql = "select * from Activity"; 
            return DapperHelper.GetList<Model.Activity>(sql);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int UptActivity(Model.Activity a)
        {
            throw new NotImplementedException();
        }
    }
}
