using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MDB
{
    public partial class AddForm : MaterialForm
    {
        public AddForm()
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

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'movieDatabaseDataSet1.Films' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmsTableAdapter.Fill(this.movieDatabaseDataSet1.Films);
            // TODO: Bu kod satırı 'movieDatabaseDataSet.Film' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into Films (ID,Name,Gerne,Director,Year) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            command.Parameters.AddWithValue("@p1", txtid.Text);
            command.Parameters.AddWithValue("@p2", txtname.Text);
            command.Parameters.AddWithValue("@p3", txtgenre.Text);
            command.Parameters.AddWithValue("@p4", txtdirector.Text);
            command.Parameters.AddWithValue("@p5", txtyear.Text);
            command.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("New movie added!");
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
