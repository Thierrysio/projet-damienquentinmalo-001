using projet_damienquentinmalo_001.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_damienquentinmalo_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CreerProjet();
            this.IncrementerCombo2();
        }

        private void IncrementerCombo2()
        {
            comboBox2.Items.Clear();
            foreach (Projet unProjet in Projet.CollClasseProjet)
            {
                comboBox2.Items.Add(unProjet.IntituleProjet);
            }
        }

        public void CreerProjet()
        {
            new Projet(int.Parse(textBox1.Text), textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CreerService();
            this.IncrementerCombo();
            this.AfficherView();
        }

        private void AfficherView()
        {
            DataTable d3 = new DataTable();

            d3.Columns.Add("Id", typeof(int));
            d3.Columns.Add("service", typeof(string));

            dataGridView2.Refresh();

            foreach (Service unService in Service.CollClasseService)
            {
                d3.Rows.Add(unService.Id_Service, unService.NomService);
            }
            dataGridView2.DataSource = d3;
        }

        public void CreerService()
        {
            new Service(int.Parse(textBox6.Text), textBox5.Text);
        }

        public void IncrementerCombo()
        {
            comboBox1.Items.Clear();
            foreach (Service unService in Service.CollClasseService)
            {
                comboBox1.Items.Add(unService.NomService);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CreerCollaborateur();
            this.AfficherCollab();

        }

        private void AfficherCollab()
        {
            DataTable d3 = new DataTable();

            d3.Columns.Add("Id", typeof(int));
            d3.Columns.Add("collab", typeof(string));

            dataGridView3.Refresh();

            foreach (Collaborateur unCollaborateur in Collaborateur.CollClasseCollaborateur)
            {
                d3.Rows.Add(unCollaborateur.IdCollaborateur, unCollaborateur.NomCollaborateur);
            }
            dataGridView3.DataSource = d3;
        }

        private void CreerCollaborateur()
        {
            ///
            // 1 - recuperer le nom du service - ok
            // 2 - recuperer l'adresse de l'objet correspondant au nom - ok
            // 3 - creer le nouveau collaborateur = ok
            // 4 - Ajouter le collaborateur à la liste de collaborateurs du projet
            ///
            ///////////////////ok

            string param = comboBox1.Text;
            ////////////////////ok
            Service leService = null;
            foreach (Service unService in Service.CollClasseService)
            {
                if (param == unService.NomService)
                {
                    leService = unService;
                    break;
                }
            }
            Collaborateur leCollaborateur = new Collaborateur(int.Parse(textBox4.Text), textBox3.Text, leService);

            ////////////////////////
            Projet leProjet = null;
            param = comboBox2.Text;
            foreach (Projet unprojet in Projet.CollClasseProjet)
            {
                if (param == unprojet.IntituleProjet)
                {
                    /// ajoute a la liste de collaborateurs du projet ce  collaborateur
                    leProjet = unprojet;
                    unprojet.LesCollabs.Add(leCollaborateur);
                    break;
                }
            }

            ///////////////////////////////
            /// 1 - creer une grille virtuelle
            /// 2 - nommer les colonnes
            /// 3 - effacer l'ancien contenu de la grille physique
            /// 4 - remplir la grille virtuelle
            /// 5 - transferer le contenu de la grille virtuelle dans la grille physique
            ///////////////////////////////
            DataTable d3 = new DataTable();

            d3.Columns.Add("Id", typeof(int));
            d3.Columns.Add("nom", typeof(string));

            dataGridView1.Refresh();

            foreach (Collaborateur unCollaborateur in leProjet.LesCollabs)
            {
                d3.Rows.Add(unCollaborateur.IdCollaborateur, unCollaborateur.NomCollaborateur);
            }

            dataGridView1.DataSource = d3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           textBox8.Text = this.AfficherService(int.Parse(textBox7.Text));
        }

        private string AfficherService(int param)
        {
            string result = null;
            foreach (Collaborateur unCollaborateur in Collaborateur.CollClasseCollaborateur)
            {
                if (param == unCollaborateur.IdCollaborateur)
                {
                    result = unCollaborateur.LeService.NomService;
                }
            }
            return result;
        }
    }

}
