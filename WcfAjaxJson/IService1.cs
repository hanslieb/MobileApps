using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfAjaxJson
{
        // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
        [ServiceContract]
        public interface IService1
        {
            //[OperationContract]
            //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json)]
            //List<EmployeeContractor> GetData();

            //[OperationContract]
            //[WebGet(ResponseFormat = WebMessageFormat.Json)]
            //List<EmployeeContractor> GetData();

            [OperationContract]
            [WebGet(ResponseFormat = WebMessageFormat.Json)]
            Stream GetData();

        }
}
