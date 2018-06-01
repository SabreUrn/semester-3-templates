using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RESTConsumer {
	public static class MenuCRUDHelper {
		public static string GetAll() {
			string s = "";
			IList<Class1> list = CRUD.GetClass1sAsync().Result;
			foreach (Class1 c1 in list) {
				s += AddWithNewLine(FormatObject(c1));
			}
			return s;
		}

		public static string GetOne() {
			int id = ReadId();
			string s = "";
			Class1 c1 = CRUD.GetClass1Async(id).Result;
			if(c1 != null) {
				s += FormatObject(CRUD.GetClass1Async(id).Result);
			} else {
				s += "No object found with that ID.";
			}
			return s;
		}

		public static string Delete() {
			int id = ReadId();
			HttpResponseMessage response = CRUD.DeleteClass1Async(id).Result;
			string s = "";
			if (response.StatusCode == HttpStatusCode.OK) {
				s += AddWithNewLine("Delete successful.");
			} else {
				s += AddWithNewLine("Delete unsuccessful. Error code " + response.StatusCode);
			}
			return s;
		}

		public static string Post() {
			Class1 c1 = ReadObjectParameters();
			HttpResponseMessage response = CRUD.PostClass1Async(c1).Result;
			string s = "";
			if (response.StatusCode == HttpStatusCode.OK) {
				s += AddWithNewLine("Post successful.");
			} else {
				s += AddWithNewLine("Post unsuccessful. Error code " + response.StatusCode);
			}
			return s;
		}

		public static string Put() {
			Class1 c1 = ReadObjectParameters();
			HttpResponseMessage response = CRUD.PutClass1Async(c1).Result;
			string s = "";
			if (response.StatusCode == HttpStatusCode.OK) {
				s += AddWithNewLine("Put successful.");
			} else {
				s += AddWithNewLine("Put unsuccessful. Error code " + response.StatusCode);
			}
			return s;
		}

		private static int ReadId() {
			Console.ReadLine();
			Console.Write("ID: ");
			Int32.TryParse(Console.ReadLine(), out int id);
			bool success = false;
			while (!success) {
				Console.WriteLine("Input must be an int.");
				Console.Write("ID: ");
				success = Int32.TryParse(Console.ReadLine(), out id);
			}
			return id;
		}

		private static Class1 ReadObjectParameters() {
			Console.WriteLine("Please enter object parameters.");
			int id = ReadId();
			return new Class1(id);
		}

		public static string Add(string s) {
			return s;
		}

		public static string AddWithNewLine(string s) {
			return s + NewLine();
		}

		public static string NewLine() {
			return "\r\n";
		}

		public static string FormatObject(Class1 c1) {
			return $"#{c1.Id}: ";
		}
	}
}
