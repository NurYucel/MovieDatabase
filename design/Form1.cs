using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MDB
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ListForm movie = new ListForm();
            movie.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            DeleteForm delete=new DeleteForm();
            delete.Show();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            EditForm edit=new EditForm();
            edit.Show();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            FilterForm filter=new FilterForm();
            filter.Show();
        }
    }
}
