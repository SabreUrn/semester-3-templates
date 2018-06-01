using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTConsumer {
	/*
	 * When updating Class1, also remember to update MenuCRUDHelper.ReadObjectParameters() and MenuCRUDHelper.FormatObject()
	 */
	class Program {
		static void Main(string[] args) {
			bool run = MenuManager.MainMenu();
			while(run) {
				run = MenuManager.MainMenu();
			}
		}
	}
}
