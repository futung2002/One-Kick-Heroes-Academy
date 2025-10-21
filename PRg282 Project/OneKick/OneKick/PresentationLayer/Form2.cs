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
using System.IO;

namespace OneKick.PresentationLayer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

        // button to show average age
        private void btnAvgAge_Click(object sender, EventArgs e)
        {

            SqlCommand avg_CMD = new SqlCommand("SELECT AGE From Heroes", con);

            SqlDataReader reader_AVG = avg_CMD.ExecuteReader();
            File.WriteAllText("summary.txt", reader_AVG);
            MessageBox.Show(reader_AVG);
        }

        //button to display the number of superheros
        private void btnNumOfSuperheroes_Click(object sender, EventArgs e)
        {
            SqlCommand count_CMD = new SqlCommand("Select Count(*) From Heroes", con);

            SqlDataReader count_Reader = count_CMD.ExecuteReader();
            File.WriteAllText("summary.txt", count_Reader);
            MessageBox.Show(count_Reader);
        private void btnAvgExamScore_Click(object sender, EventArgs e)
        {
            SqlCommand exam_CMD = new SqlCommand("SELECT EXAM From Heroes", con);

            SqlDataReader exam_Reader = exam_CMD.ExecuteReader();
            File.WriteAllText("summary.txt", exam_Reader);
            MessageBox.Show(exam_Reader);
        }
    }
}
