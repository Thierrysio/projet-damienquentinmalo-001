using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_damienquentinmalo_001.Modeles
{
    class Service
    {
        #region Attributs
        public static List<Service> CollClasseService = new List<Service>();
        private int _id_Service;
        private string _nomService;

        
        #endregion
        #region Constructeurs
        public Service(int id_Service, string nomService)
        {
            _id_Service = id_Service;
            _nomService = nomService;
            Service.CollClasseService.Add(this);
        }

        #endregion
        #region Attributs Getters Setters
        public int Id_Service { get => _id_Service; set => _id_Service = value; }
        public string NomService { get => _nomService; set => _nomService = value; }

        #endregion
        #region Attributs Methodes
        #endregion
    }
}
