using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPProvider {
	[ServiceContract]
	public interface IService1 {

		//[OperationContract]
	}


	[DataContract]
	public class CompositeType {
		bool boolValue = true;
		string stringValue = "Hello ";

		[DataMember]
		public bool BoolValue {
			get { return boolValue; }
			set { boolValue = value; }
		}

		[DataMember]
		public string StringValue {
			get { return stringValue; }
			set { stringValue = value; }
		}
	}
}
