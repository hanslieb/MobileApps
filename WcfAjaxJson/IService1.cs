using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WcfAjaxJson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //[ServiceContract(Namespace = "")]
    //public interface IService1
    //{

    //    [OperationContract]
    //    string GetData(string value);

    //    [OperationContract]
    //    string GetString();

    //    [OperationContract]
    //    CompositeType GetDataUsingDataContract(CompositeType composite);

    //    // TODO: Add your service operations here
    //}


    //// Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
        // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
        [ServiceContract]
        public interface IService1
        {
            [OperationContract]
            [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json)]
            string[][] GetData();
        }


        // Use a data contract as illustrated in the sample below to add composite types to service operations.
 
}
