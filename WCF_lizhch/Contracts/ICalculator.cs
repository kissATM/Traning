using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract(Name="CaculatorService",Namespace="http://www.gwm.cn")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double a, double b);
    }
}
