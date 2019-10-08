using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [ServiceContract]
    public interface IReportService
    {
        //Consider report process is lengthy process and take significant time.
        [OperationContract]
        void ProcessReport();
    }
}
