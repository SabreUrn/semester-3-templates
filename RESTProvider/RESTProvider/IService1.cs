using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTProvider {
	[ServiceContract]
	public interface IService1 {

		[OperationContract]
		[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "class1/")]
		IList<Class1> GetClass1s();

		[OperationContract]
		[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "class1?id={id}")]
		Class1 GetClass1(int id);

		[OperationContract]
		[WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "class1?id={id}")]
		void DeleteClass1(int id);

		[OperationContract]
		[WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "class1/")]
		void PutClass1(Class1 customer);

		[OperationContract]
		[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "class1/")]
		void UpdateClass1(Class1 customer);
	}


	//[DataContract]
	//public class CompositeType {
	//	[DataMember]
	//	public bool BoolValue { get; set; } = true;
	//}
}
