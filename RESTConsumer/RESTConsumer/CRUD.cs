using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RESTConsumer {
	public static class CRUD {
		private static string class1Uri = "http://localhost:26649/Service1.svc/customers/";
		private static string class1UriQuery = "http://localhost:26649/Service1.svc/customers?id=";

		public static async Task<IList<Class1>> GetClass1sAsync() {
			using (HttpClient client = new HttpClient()) {
				string content = await client.GetStringAsync(class1Uri + "/");
				IList<Class1> c1List = JsonConvert.DeserializeObject<IList<Class1>>(content);
				return c1List;
			}
		}

		public static async Task<Class1> GetClass1Async(int id) {
			using (HttpClient client = new HttpClient()) {
				string content = await client.GetStringAsync(class1UriQuery + id);
				Class1 c1 = JsonConvert.DeserializeObject<Class1>(content);
				return c1;
			}
		}

		public static async Task<HttpResponseMessage> DeleteClass1Async(int id) {
			using (HttpClient client = new HttpClient()) {
				HttpResponseMessage response = await client.DeleteAsync(class1UriQuery + id);
				return response;
			}
		}

		public static async Task<HttpResponseMessage> PostClass1Async(Class1 c1) {
			using (HttpClient client = new HttpClient()) {
				string json = JsonConvert.SerializeObject(c1);
				//byte[] buffer = Encoding.UTF8.GetBytes(json);
				//ByteArrayContent content = new ByteArrayContent(buffer);
				StringContent content = new StringContent(json);
				content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
				HttpResponseMessage response = await client.PostAsync(class1Uri, content);
				return response;
			}
		}

		public static async Task<HttpResponseMessage> PutClass1Async(Class1 c1) {
			using (HttpClient client = new HttpClient()) {
				string json = JsonConvert.SerializeObject(c1);
				//byte[] buffer = Encoding.UTF8.GetBytes(json);
				//ByteArrayContent content = new ByteArrayContent(buffer);
				StringContent content = new StringContent(json);
				content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
				HttpResponseMessage response = await client.PutAsync(class1Uri, content);
				return response;
			}
		}
	}
}
