using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace WcfAjaxJson
{
    //// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    //[ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    //public class Service1 : IService1
    //{
    //    //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
    //    [WebGet]
    //    public string GetData(string value)
    //    {
    //        return string.Format("You entered: {0}", value);
    //    }

    //    public string GetString()
    //    {
    //        return "Hello World";
    //    }

    //    public CompositeType GetDataUsingDataContract(CompositeType composite)
    //    {
    //        if (composite == null)
    //        {
    //            throw new ArgumentNullException("composite");
    //        }
    //        if (composite.BoolValue)
    //        {
    //            composite.StringValue += "Suffix";
    //        }
    //        return composite;
    //    }
    //}

    [DataContract]
    public class EmployeeContractor
    {
        [DataMember]
        public string EmployeeCount { get; set; }
        [DataMember]
        public string ContractorCount { get; set; }
        [DataMember]
        public string PlantCode { get; set; }
        [DataMember]
        public string DateStamp { get; set; }
    }

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class Service1 : IService1
    {
        //public string GetData()
        //{
        //    //WebOperationContext.Current.OutgoingResponse.Headers.Add(
        //    //    "Access-Control-Allow-Origin", "*"); WebOperationContext.Current.OutgoingResponse.Headers.Add(
        //    //        "Access-Control-Allow-Methods", "GET");
        //    //WebOperationContext.Current.OutgoingResponse.Headers.Add(
        //    //    "Access-Control-Allow-Headers", "Content-Type, Accept");

        //    //var jsonObject = new[]
        //    //           {
        //    //               new[] {"0", "76", "VAN", "2012-09-14"},
        //    //               new[] {"62", "0", "TSP", "2012-09-14"},
        //    //               new[] {"0", "205", "SUB", "2012-09-14"},
        //    //               new[] {"309", "233", "STP", "2012-09-14"},
        //    //               new[] {"206", "78", "STM", "2012-09-14"},
        //    //               new[] {"0", "87", "SHC", "2012-09-14"},
        //    //               new[] {"34", "4", "SEC", "2012-09-14"},
        //    //               new[] {"0", "18", "REF", "2012-09-14"},
        //    //               new[] {"0", "51", "PSR", "2012-09-14"},
        //    //               new[] {"13", "0", "PSO", "2012-09-14"},
        //    //               new[] {"13", "0", "ORD", "2012-09-14"},
        //    //               new[] {"0", "4", "MET", "2012-09-14"},
        //    //               new[] {"131", "207", "MAP", "2012-09-14"},
        //    //               new[] {"0", "6", "LOC", "2012-09-14"},
        //    //               new[] {"64", "0", "LAB", "2012-09-14"},
        //    //               new[] {"308", "350", "IRM", "2012-09-14"},
        //    //               new[] {"119", "36", "HRD", "2012-09-14"},
        //    //               new[] {"189", "24", "FLP", "2012-09-14"},
        //    //               new[] {"23", "4", "FIN", "2012-09-14"},
        //    //               new[] {"0", "21", "ENV", "2012-09-14"},
        //    //               new[] {"102", "143", "ENG", "2012-09-14"},
        //    //               new[] {"21", "5", "CSD", "2012-09-14"},
        //    //               new[] {"0", "37", "BSS", "2012-09-14"},
        //    //               new[] {"49", "0", "ADM", "2012-09-14"},
        //    //               new[] {"0", "10", "---", "2012-09-14"}
        //    //           };
        //    //return new List<EmployeeContractor>()
        //    //           {
        //    //               new EmployeeContractor()
        //    //                   {
        //    //                       EmployeeCount = "0",
        //    //                       ContractorCount = "76",
        //    //                       PlantCode = "VAN",
        //    //                       DateStamp = "2012-09-14"
        //    //                   },
        //    //               new EmployeeContractor()
        //    //                   {
        //    //                       EmployeeCount = "62",
        //    //                       ContractorCount = "0",
        //    //                       PlantCode = "TSP",
        //    //                       DateStamp = "2012-09-14"
        //    //                   }
        //    //           };

        //    //return HttpContext.Current.Request["callback"] + @"([{'ContractorCount':'76','DateStamp':'2012-09-14','EmployeeCount':'0','PlantCode':'VAN'}])";

        //    return HttpContext.Current.Request["callback"] +
        //           @"({""values"":[{""ContractorCount"":""76"",""DateStamp"":""2012-09-14"",""EmployeeCount"":""0"",""PlantCode"":""VAN""}]});";
        //}

        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        //public string GetResults()
        public Stream GetData()
        {
            List<EmployeeContractor> results = new List<EmployeeContractor>
                                                   { new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "75",
                                                               PlantCode = "VAN",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "60",
                                                               ContractorCount = "0",
                                                               PlantCode = "TSP",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "200",
                                                               PlantCode = "SUB",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "305",
                                                               ContractorCount = "235",
                                                               PlantCode = "STP",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "210",
                                                               ContractorCount = "80",
                                                               PlantCode = "STM",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "35",
                                                               ContractorCount = "5",
                                                               PlantCode = "SEC",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "18",
                                                               PlantCode = "REF",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "45",
                                                               PlantCode = "PSR",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "12",
                                                               ContractorCount = "0",
                                                               PlantCode = "PS0",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "13",
                                                               ContractorCount = "0",
                                                               PlantCode = "ORD",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "4",
                                                               PlantCode = "MET",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "132",
                                                               ContractorCount = "220",
                                                               PlantCode = "MAP",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "6",
                                                               PlantCode = "LOC",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "62",
                                                               ContractorCount = "0",
                                                               PlantCode = "LAB",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "310",
                                                               ContractorCount = "340",
                                                               PlantCode = "IRM",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "120",
                                                               ContractorCount = "38",
                                                               PlantCode = "HRD",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "190",
                                                               ContractorCount = "20",
                                                               PlantCode = "FLP",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "23",
                                                               ContractorCount = "10",
                                                               PlantCode = "FIN",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "21",
                                                               PlantCode = "ENV",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "101",
                                                               ContractorCount = "140",
                                                               PlantCode = "ENG",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "30",
                                                               ContractorCount = "0",
                                                               PlantCode = "ITS",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "30",
                                                               PlantCode = "BSS",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "48",
                                                               ContractorCount = "0",
                                                               PlantCode = "ADM",
                                                               DateStamp = "2012-11-02"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "76",
                                                               PlantCode = "VAN",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "62",
                                                               ContractorCount = "0",
                                                               PlantCode = "TSP",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "205",
                                                               PlantCode = "SUB",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "309",
                                                               ContractorCount = "233",
                                                               PlantCode = "STP",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "206",
                                                               ContractorCount = "78",
                                                               PlantCode = "STM",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "34",
                                                               ContractorCount = "4",
                                                               PlantCode = "SEC",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "18",
                                                               PlantCode = "REF",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "51",
                                                               PlantCode = "PSR",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "13",
                                                               ContractorCount = "0",
                                                               PlantCode = "PS0",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "13",
                                                               ContractorCount = "0",
                                                               PlantCode = "ORD",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "4",
                                                               PlantCode = "MET",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "131",
                                                               ContractorCount = "207",
                                                               PlantCode = "MAP",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "6",
                                                               PlantCode = "LOC",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "64",
                                                               ContractorCount = "0",
                                                               PlantCode = "LAB",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "308",
                                                               ContractorCount = "350",
                                                               PlantCode = "IRM",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "119",
                                                               ContractorCount = "36",
                                                               PlantCode = "HRD",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "189",
                                                               ContractorCount = "24",
                                                               PlantCode = "FLP",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "23",
                                                               ContractorCount = "4",
                                                               PlantCode = "FIN",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "21",
                                                               PlantCode = "ENV",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "102",
                                                               ContractorCount = "143",
                                                               PlantCode = "ENG",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "21",
                                                               ContractorCount = "5",
                                                               PlantCode = "ITS",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "0",
                                                               ContractorCount = "37",
                                                               PlantCode = "BSS",
                                                               DateStamp = "2012-11-03"
                                                           },
                                                       new EmployeeContractor()
                                                           {
                                                               EmployeeCount = "49",
                                                               ContractorCount = "0",
                                                               PlantCode = "ADM",
                                                               DateStamp = "2012-11-03"
                                                           }
                                                   };

            // Serialize the results as JSON
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(results.GetType());
            MemoryStream memoryStream = new MemoryStream();
            serializer.WriteObject(memoryStream, results);

            // Return the results serialized as JSON
            //string json = Encoding.Default.GetString(memoryStream.ToArray());
            //return json;
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            memoryStream.Position = 0;
            return memoryStream;
        }
    }
}
