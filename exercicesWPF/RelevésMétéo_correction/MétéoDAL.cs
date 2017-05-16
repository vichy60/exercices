using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RelevésMétéo
{
	public class MétéoDAL
	{
		private List<DonnéesMois> _data;
		public List<DonnéesMois> Data
		{
			get { return _data; }
		}

		private Statistiques _stats;
		public Statistiques Stats
		{
			get { return _stats; }
		}

		public MétéoDAL()
		{
			_data = new List<DonnéesMois>();
		}

		public void ChargerDonnées(string chemin)
		{
			_data.Clear();

			int cpt = 0;
			using (StreamReader str = new StreamReader(chemin))
			{
				string ligne;

				while ((ligne = str.ReadLine()) != null)
				{
					cpt++;
					if (cpt == 1) continue; // On n'analyse pas la première ligne car elle contient les en-têtes

					var tab = ligne.Split('\t');
					var donnéesMois = new DonnéesMois(
						DateTime.Parse(tab[0]),
						double.Parse(tab[1]),
						double.Parse(tab[2]),
						double.Parse(tab[3]),
						double.Parse(tab[4]));

					// Ajout des données du mois à la liste
					_data.Add(donnéesMois);
				}
			}

			// Initialise les statistiques
			_stats = new Statistiques(_data);
		}
	}

	/// <summary>
	///  Statistiques sur les données météorologiques
	/// </summary>
	public class Statistiques
	{
		public DateTime MoisPlusFroid { get; }
		public double TMin { get; }

		public DateTime MoisPlusChaud { get; }
		public double TMax { get; }

		public int AnnéePlusSèche { get; }
		public double PrécipitationsMin { get; }

		public int AnnéePlusHumide { get; }
		public double PrécipitationsMax { get; }

		private enum Op { Min, Max }

		public Statistiques(List<DonnéesMois> data)
		{
			DonnéesMois dm;

			dm = data.Where(D => D.TMin == data.Min(d => d.TMin)).First();
			MoisPlusFroid = dm.Date;
			TMin = dm.TMin;

			dm = data.Where(D => D.TMax == data.Max(d => d.TMax)).First();
			MoisPlusChaud = dm.Date;
			TMax = dm.TMax;

			dm = PrécipitationsAnnée(data, Op.Min);
			AnnéePlusSèche = dm.Année;
			PrécipitationsMin = dm.Précipitations;

			dm = PrécipitationsAnnée(data, Op.Max);
			AnnéePlusHumide = dm.Année;
			PrécipitationsMax = dm.Précipitations;
		}

		private DonnéesMois PrécipitationsAnnée(List<DonnéesMois> data, Op op)
		{
			double precip;
			double P = (op == Op.Min ? 10000 : 0);	// Précipitations min ou max
			int A = 0;	// Année des précipitations min ou max

			foreach (var an in data.Select(d => d.Année).Distinct())
			{
				precip = data.Where(a => a.Année == an).Sum(d => d.Précipitations);
				if (op == Op.Min && precip < P || op == Op.Max && precip > P)
				{
					A = an;
					P = precip;
				}
			}
			return new DonnéesMois(new DateTime(A, 1, 1), 0, 0, P, 0);
		}
	}

	/// <summary>
	/// Classe contenant les données d'un mois de relevé météo
	/// </summary>
	public class DonnéesMois
	{
		public DateTime Date { get; }
		public int Année
		{
			get { return Date.Year; }
		}
		public int Mois
		{
			get { return Date.Month; }
		}
		public double TMin { get; }
		public double TMax { get; }
		public double Précipitations { get; }
		public double Ensoleillement { get; }

		public DonnéesMois(DateTime date, double tmin, double tmax, double précip, double ensol)
		{
			Date = date;
			TMin = tmin;
			TMax = tmax;
			Précipitations = précip;
			Ensoleillement = ensol;
		}
	}
}
