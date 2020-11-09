using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_damienquentinmalo_001.Modeles
{
    class Projet
    {


        #region Attributs
        public static List<Projet> CollClasseProjet = new List<Projet>();
        private int _idProjet;
        private string _intituleProjet;
        private string _etat;
        private List<Collaborateur> _lesCollabs;
        #endregion
        #region Constructeurs
        public Projet(int idProjet, string intituleProjet)
        {
            _idProjet = idProjet;
            _intituleProjet = intituleProjet;
            _etat = "pas commence" ;
            _lesCollabs = new List<Collaborateur>();
        }

        #endregion
        #region Attributs Getters Setters
        public int IdProjet { get => _idProjet; set => _idProjet = value; }
        public string IntituleProjet { get => _intituleProjet; set => _intituleProjet = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public List<Collaborateur> LesCollabs { get => _lesCollabs; set => _lesCollabs = value; }

        #endregion
        #region Attributs Methodes


        #endregion

    }
}
