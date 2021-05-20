using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.IRepository.Specification
{
    public interface ISpecificationRepository:IBaseRepository<IOT.Core.Model.Specification>
    {
        List<Model.Specification> Query(string commspec = "");
    }
}
