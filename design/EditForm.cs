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
    public partial class EditForm : MaterialForm
    {
        public EditForm()
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

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'movieDatabaseDataSet1.Films' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmsTableAdapter.Fill(this.movieDatabaseDataSet1.Films);
            // TODO: Bu kod satırı 'movieDatabaseDataSet.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.filmTableAdapter.Fill(this.movieDatabaseDataSet.Film);

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand commandUpdate = new SqlCommand("Update Films Set Name=@a2,Gerne=@a3,Director=@a4,Year=@a5 Where  ID= @a1", baglanti);
            commandUpdate.Parameters.AddWithValue("@a1", txtid.Text);
            commandUpdate.Parameters.AddWithValue("@a2",txtname.Text);
            commandUpdate.Parameters.AddWithValue("@a3", txtgenre.Text);
            commandUpdate.Parameters.AddWithValue("@a4",txtdirector.Text);
            commandUpdate.Parameters.AddWithValue("@a5", txtyear.Text);
            commandUpdate.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Movie update!");
            txtid.Clear();
            txtname.Clear();
            txtgenre.Clear();
            txtyear.Clear();
            txtdirector.Clear();

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.filmsTableAdapter.Fill(this.movieDatabaseDataSet1.Films);
        }
    }
}
