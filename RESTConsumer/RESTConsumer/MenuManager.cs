using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RESTConsumer {
	public static class MenuManager {
		public static bool MainMenu() {
			Console.Clear();
			string menuText = "";
			menuText += Title();
			menuText += Options();
			Console.WriteLine(menuText);
			return ReadResponse();
		}


		private static string Title() {
			string s = "";
			s += AddWithNewLine("Class1 REST consumer");
			s += AddWithNewLine("--------------------");
			s += NewLine();
			return s;
		}

		private static string Options() {
			string s = "";
			s += AddWithNewLine("1. GET all objects from service");
			s += AddWithNewLine("2. GET one objects from service");
			s += AddWithNewLine("3. DELETE object from service");
			s += AddWithNewLine("4. POST object to service");
			s += AddWithNewLine("5. PUT object to service");
			s += AddWithNewLine("Press enter to exit.");
			s += NewLine();
			s += Add("Choose option: ");
			return s;
		}

		public static bool ReadResponse() {
			bool run = true;
			ConsoleKeyInfo response = Console.ReadKey(true);
			switch(response.Key) {
				case ConsoleKey.D1:
					Console.WriteLine(MenuCRUDHelper.GetAll());
					break;
				case ConsoleKey.D2:
					Console.WriteLine(MenuCRUDHelper.GetOne());
					break;
				case ConsoleKey.D3:
					Console.WriteLine(MenuCRUDHelper.Delete());
					break;
				case ConsoleKey.D4:
					Console.WriteLine(MenuCRUDHelper.Post());
					break;
				case ConsoleKey.D5:
					Console.WriteLine(MenuCRUDHelper.Put());
					break;
				case ConsoleKey.Enter:
					run = false;
					break;
				default:
					break;
			}
			return run;
		}

		private static string Add(string s) {
			return s;
		}
		
		private static string AddWithNewLine(string s) {
			return s + NewLine();
		}

		private static string NewLine() {
			return "\r\n";
		}

		private static string FormatObject(Class1 c1) {
			return $"#{c1.Id}: ";
		}
	}
}
