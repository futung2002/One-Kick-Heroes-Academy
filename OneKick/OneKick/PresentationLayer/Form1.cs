using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneKick.BusinessLogicLayer;
using OneKick.DataLayer;

namespace OneKick
{
    public partial class Form1 : Form
    {
        private HeroManager manager = new HeroManager();
        public Form1()
        {
            InitializeComponent();
        }

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
        private void ClearFields()
        {
            txtHeroID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtSuperpower.Clear();
            txtExamScore.Clear();
        }
    }
}
