using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.CommissionRecord
{
    public interface ICommissionRecordRepository 
    {
        List<IOT.Core.Model.CommissionRecord> ShowCommissionRecord();
    }
}
