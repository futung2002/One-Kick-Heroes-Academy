using OneKick.BusinessLogicLayer;
using OneKick.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OneKick
{
    public partial class Form1 : Form
    {
        private HeroManager manager = new HeroManager();
        public Form1()
        {
            InitializeComponent();
        }


        //button to add hero to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Hero hero = new Hero
                {
                    HeroID = txtHeroID.Text,
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Superpower = txtSuperpower.Text,
                    ExamScore = int.Parse(txtExamScore.Text),
                };

                manager.AddHero(hero);
                MessageBox.Show("Hero was successfully added");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //button tp view the heroes that are on the database
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHeroes.AutoGenerateColumns = true;
                var list = manager.GetAllHeroes();

                dgvHeroes.DataSource = new BindingList<Hero>(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading heroes: " + ex.Message);
            }
        }

        //clears the form 
        private void ClearFields()
        {
            txtHeroID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtSuperpower.Clear();
            txtExamScore.Clear();
        }


        //button to delete a hero *
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand delete_CMD = new SqlCommand("DELETE FROM Heroes WHERE NAME = @txtName", con);
        }

        //button to update the hero on the database onto the dgv
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
