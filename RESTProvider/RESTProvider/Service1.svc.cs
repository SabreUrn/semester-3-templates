using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTProvider {
	public class Service1 : IService1 {
		private static List<Class1> c1List = new List<Class1>();

		public IList<Class1> GetClass1s() {
			return c1List;
		}

		public Class1 GetClass1(int id) {
			return c1List.FirstOrDefault(c => c.Id == id);
		}

		public void DeleteClass1(int id) {
			Class1 c1 = c1List.FirstOrDefault(c => c.Id == id);
			if (c1 != null || c1List.Contains(c1)) c1List.Remove(c1);
		}

		public void PutClass1(Class1 c1) {
			if (c1List != null) c1List.Add(c1);
		}

		public void UpdateClass1(Class1 c1) {
			try {
				int index = c1List.FindIndex(c => c.Id == c1.Id);
				c1List[index].Id = c1.Id;

			} catch (ArgumentNullException) {
			}
		}
	}
}
