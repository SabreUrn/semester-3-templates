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
			s += MenuCRUDHelper.AddWithNewLine("Class1 REST consumer");
			s += MenuCRUDHelper.AddWithNewLine("--------------------");
			s += MenuCRUDHelper.NewLine();
			return s;
		}

		private static string Options() {
			string s = "";
			s += MenuCRUDHelper.AddWithNewLine("1. GET all objects from service");
			s += MenuCRUDHelper.AddWithNewLine("2. GET one objects from service");
			s += MenuCRUDHelper.AddWithNewLine("3. DELETE object from service");
			s += MenuCRUDHelper.AddWithNewLine("4. POST object to service");
			s += MenuCRUDHelper.AddWithNewLine("5. PUT object to service");
			s += MenuCRUDHelper.AddWithNewLine("Press enter to exit.");
			s += MenuCRUDHelper.NewLine();
			s += MenuCRUDHelper.Add("Choose option: ");
			return s;
		}

		public static bool ReadResponse() {
			bool run = true;
			ConsoleKeyInfo response = Console.ReadKey(true);
			switch(response.Key) {
				case ConsoleKey.D1:
					Console.WriteLine(MenuCRUDHelper.GetAll());
					PauseForInput();
					break;
				case ConsoleKey.D2:
					Console.WriteLine(MenuCRUDHelper.GetOne());
					PauseForInput();
					break;
				case ConsoleKey.D3:
					Console.WriteLine(MenuCRUDHelper.Delete());
					PauseForInput();
					break;
				case ConsoleKey.D4:
					Console.WriteLine(MenuCRUDHelper.Post());
					PauseForInput();
					break;
				case ConsoleKey.D5:
					Console.WriteLine(MenuCRUDHelper.Put());
					PauseForInput();
					break;
				case ConsoleKey.Enter:
					run = false;
					break;
				default:
					break;
			}
			return run;
		}

		private static void PauseForInput() {
			Console.WriteLine("Press any key to continue.");
			Console.ReadKey();
		}
	}
}
