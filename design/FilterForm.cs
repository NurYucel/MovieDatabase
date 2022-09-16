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
    public partial class FilterForm : MaterialForm
    {
        public FilterForm()
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

       
        private void FilterForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'movieDatabaseDataSet1.Films' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmsTableAdapter.Fill(this.movieDatabaseDataSet1.Films);

        }

        private void yearbutton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Films Where Year like'" + txtyear.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds,"Films");
            dataGridView1.DataSource = ds.Tables["Films"];
            baglanti.Close();
        }

        private void fromtobutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlDataAdapter a3 = new SqlDataAdapter("Select * From Films Where Year Between @k1 And @k2", baglanti);
            DataSet d3 = new DataSet();
            a3.SelectCommand.Parameters.AddWithValue("@k1", txtfrom1.Text);
            a3.SelectCommand.Parameters.AddWithValue("@k2", txtto1.Text);
            a3.Fill(d3, "Films");
            dataGridView1.DataSource = d3.Tables["Films"];
            baglanti.Close();
            /*string sql = "Select *From Films Where Year Between @k1 And @k1";
            DataTable table=new DataTable();
            SqlDataAdapter adabter = new SqlDataAdapter(sql, baglanti);
            adabter.SelectCommand.Parameters.AddWithValue("@k1", txtfrom1.Text);
            adabter.SelectCommand.Parameters.AddWithValue("@k2", txtto1.Text);
            adabter.Fill(table);


            baglanti.Close();
            dataGridView1.DataSource = table;*/
        }

        private void direkfromtobutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter a4 = new SqlDataAdapter("Select * From Films Where (Director= '" + txtdirek2.Text + "' And Year Between @a1 And @a2)", baglanti);
            DataSet d4 =new DataSet();
            a4.SelectCommand.Parameters.AddWithValue("@a1", txtfrom2.Text);
            a4.SelectCommand.Parameters.AddWithValue("@a2", txtto2.Text);
            a4.Fill(d4, "Films");
            dataGridView1.DataSource = d4.Tables["Films"];
            baglanti.Close();
        }

        private void genrebutton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter a1 = new SqlDataAdapter("Select * From Films Where Gerne like'" + comboBox1.Text + "%'", baglanti);
            DataSet d1 = new DataSet();
            baglanti.Open();
            a1.Fill(d1, "Films");
            dataGridView1.DataSource = d1.Tables["Films"];
            baglanti.Close();
        }

        private void direktorbutton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter a2 = new SqlDataAdapter("Select * From Films Where Director like '" + txtdirek3.Text + "%'", baglanti);
            DataSet d2 = new DataSet();
            baglanti.Open();
            a2.Fill(d2, "Films");
            dataGridView1.DataSource = d2.Tables["Films"];
            baglanti.Close();
        }
    }
}
