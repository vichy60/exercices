using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Trombinoscope
{
	public class Employe
	{
		public int Id { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }

		public string NomComplet { get { return Nom + " " + Prenom; } }
		public DateTime DateEmbauche { get; set; }
		public ImageSource Photo { get; set; }
		public List<Territoire> Territoires { get; set; }

	}

	public class Territoire
	{
		public string Code { get; set; }
		public string Description { get; set; }
	}
}
