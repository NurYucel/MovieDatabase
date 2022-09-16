using MaterialSkin;
using MaterialSkin.Controls;
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

namespace MDB
{
    public partial class DeleteForm : MaterialForm
    {
        public DeleteForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0P6JLDA;Initial Catalog=MovieDatabase;Integrated Security=True");

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'movieDatabaseDataSet1.Films' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmsTableAdapter.Fill(this.movieDatabaseDataSet1.Films);
            // TODO: Bu kod satırı 'movieDatabaseDataSet.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand commandDelete = new SqlCommand("Delete From Films Where ID=@k1", baglanti);
            commandDelete.Parameters.AddWithValue("@k1",txtid.Text);
            commandDelete.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Selected movie deleted!");
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.filmTableAdapter.Fill(this.movieDatabaseDataSet.Film);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            this.filmsTableAdapter.Fill(this.movieDatabaseDataSet1.Films);
        }
    }
}
