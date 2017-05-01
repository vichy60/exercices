using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
	static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            //DAL.GetRegion();
			Application.Run(new MDIForm());

            

		}

    
	}
}
