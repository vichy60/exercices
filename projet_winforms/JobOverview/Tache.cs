using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Tache
    {
        #region propriétés
        public int IdTache { get; set; }
        public string Libelle { get; set; }
        public bool Annexe { get; set; }
        public string CodeActivite { get; set; }
        public string Login { get; set; }
        public string Description { get; set; }
        public int Numero { get; set; }
        public float  DureePrevue { get; set; }
        public float DureeRestanteEstimee { get; set; }
        public string CodeModule { get; set; }

        public string CodeLogicieModule { get; set; }
        public float NumeroVersion { get; set; }
        public string CodeLogicielVersion { get; set; }



        #endregion


    }
}
