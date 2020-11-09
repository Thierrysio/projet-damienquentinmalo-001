using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_damienquentinmalo_001.Modeles
{
    class Collaborateur
    {
        #region Attributs
        public static List<Collaborateur> CollClasseCollaborateur = new List<Collaborateur>();
        private int _idCollaborateur;
        private string _nomCollaborateur;
        private Service _leService;

        
        #endregion
        #region Constructeurs
        public Collaborateur(int idCollaborateur, string nomCollaborateur, Service leService)
        {
            _idCollaborateur = idCollaborateur;
            _nomCollaborateur = nomCollaborateur;
            _leService = leService;
            Collaborateur.CollClasseCollaborateur.Add(this);
        }

        #endregion
        #region Attributs Getters Setters
        public int IdCollaborateur { get => _idCollaborateur; set => _idCollaborateur = value; }
        public string NomCollaborateur { get => _nomCollaborateur; set => _nomCollaborateur = value; }
        public Service LeService { get => _leService; set => _leService = value; }

        #endregion
        #region Attributs Methodes
        #endregion
    }
}
