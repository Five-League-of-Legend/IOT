using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOT.Core.Common;
using IOT.Core.IRepository.Sett;

namespace IOT.Core.Repository.Sett
{
    public class SettRepository : ISettRepository
    {
        public int AddSett(Model.Sett a)
        {
            string sql = $"insert into Sett values (null,'{a.Money}', '{(a.Shen?0:1)}')";
            return DapperHelper.Execute(sql);
        }
    }
}
