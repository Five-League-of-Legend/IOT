using IOT.Core.IRepository.Colonel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOT.Core.Common;
using IOT.Core.Model;

namespace IOT.Core.Repository.Colonel
{
    public class ColonelRepository : IColonelRepository
    {
        public List<Model.Colonel> ShowColonel()
        {
            string sql = " select * from Colonel ";
            return DapperHelper.GetList<Model.Colonel>(sql);
        }
    }
}
