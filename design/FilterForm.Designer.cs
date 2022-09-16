namespace MDB
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.yearbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtfrom1 = new System.Windows.Forms.TextBox();
            this.txtto1 = new System.Windows.Forms.TextBox();
            this.fromtobutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdirek2 = new System.Windows.Forms.TextBox();
            this.txtfrom2 = new System.Windows.Forms.TextBox();
            this.txtto2 = new System.Windows.Forms.TextBox();
            this.direkfromtobutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.genrebutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.direktorbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtdirek3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieDatabaseDataSet1 = new MDB.MovieDatabaseDataSet1();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new MDB.MovieDatabaseDataSet1TableAdapters.FilmsTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(13, 31);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 22);
            this.txtyear.TabIndex = 1;
            // 
            // yearbutton
            // 
            this.yearbutton.AutoSize = true;
            this.yearbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yearbutton.Depth = 0;
            this.yearbutton.Icon = null;
            this.yearbutton.Location = new System.Drawing.Point(143, 24);
            this.yearbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearbutton.Name = "yearbutton";
            this.yearbutton.Primary = true;
            this.yearbutton.Size = new System.Drawing.Size(88, 36);
            this.yearbutton.TabIndex = 2;
            this.yearbutton.Text = "Search";
            this.yearbutton.UseVisualStyleBackColor = true;
            this.yearbutton.Click += new System.EventHandler(this.yearbutton_Click);
            // 
            // txtfrom1
            // 
            this.txtfrom1.Location = new System.Drawing.Point(12, 29);
            this.txtfrom1.Name = "txtfrom1";
            this.txtfrom1.Size = new System.Drawing.Size(100, 22);
            this.txtfrom1.TabIndex = 3;
            // 
            // txtto1
            // 
            this.txtto1.Location = new System.Drawing.Point(142, 29);
            this.txtto1.Name = "txtto1";
            this.txtto1.Size = new System.Drawing.Size(100, 22);
            this.txtto1.TabIndex = 4;
            // 
            // fromtobutton
            // 
            this.fromtobutton.AutoSize = true;
            this.fromtobutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fromtobutton.Depth = 0;
            this.fromtobutton.Icon = null;
            this.fromtobutton.Location = new System.Drawing.Point(75, 57);
            this.fromtobutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fromtobutton.Name = "fromtobutton";
            this.fromtobutton.Primary = true;
            this.fromtobutton.Size = new System.Drawing.Size(88, 36);
            this.fromtobutton.TabIndex = 5;
            this.fromtobutton.Text = "Search";
            this.fromtobutton.UseVisualStyleBackColor = true;
            this.fromtobutton.Click += new System.EventHandler(this.fromtobutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "To";
            // 
            // txtdirek2
            // 
            this.txtdirek2.Location = new System.Drawing.Point(12, 29);
            this.txtdirek2.Name = "txtdirek2";
            this.txtdirek2.Size = new System.Drawing.Size(100, 22);
            this.txtdirek2.TabIndex = 12;
            // 
            // txtfrom2
            // 
            this.txtfrom2.Location = new System.Drawing.Point(16, 76);
            this.txtfrom2.Name = "txtfrom2";
            this.txtfrom2.Size = new System.Drawing.Size(100, 22);
            this.txtfrom2.TabIndex = 13;
            // 
            // txtto2
            // 
            this.txtto2.Location = new System.Drawing.Point(145, 76);
            this.txtto2.Name = "txtto2";
            this.txtto2.Size = new System.Drawing.Size(100, 22);
            this.txtto2.TabIndex = 14;
            // 
            // direkfromtobutton
            // 
            this.direkfromtobutton.AutoSize = true;
            this.direkfromtobutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.direkfromtobutton.Depth = 0;
            this.direkfromtobutton.Icon = null;
            this.direkfromtobutton.Location = new System.Drawing.Point(91, 104);
            this.direkfromtobutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.direkfromtobutton.Name = "direkfromtobutton";
            this.direkfromtobutton.Primary = true;
            this.direkfromtobutton.Size = new System.Drawing.Size(88, 36);
            this.direkfromtobutton.TabIndex = 15;
            this.direkfromtobutton.Text = "Search";
            this.direkfromtobutton.UseVisualStyleBackColor = true;
            this.direkfromtobutton.Click += new System.EventHandler(this.direkfromtobutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Movie Genre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Korku",
            "Fantastik",
            "Komedi",
            "Aksiyon",
            "Macera",
            "Animasyon",
            "Dram",
            "Bilim Kurgu",
            "Gizem",
            "Suç"});
            this.comboBox1.Location = new System.Drawing.Point(3, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // genrebutton
            // 
            this.genrebutton.AutoSize = true;
            this.genrebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.genrebutton.Depth = 0;
            this.genrebutton.Icon = null;
            this.genrebutton.Location = new System.Drawing.Point(151, 29);
            this.genrebutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.genrebutton.Name = "genrebutton";
            this.genrebutton.Primary = true;
            this.genrebutton.Size = new System.Drawing.Size(88, 36);
            this.genrebutton.TabIndex = 19;
            this.genrebutton.Text = "Search";
            this.genrebutton.UseVisualStyleBackColor = true;
            this.genrebutton.Click += new System.EventHandler(this.genrebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtyear);
            this.panel1.Controls.Add(this.yearbutton);
            this.panel1.Location = new System.Drawing.Point(21, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 67);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtfrom1);
            this.panel2.Controls.Add(this.txtto1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fromtobutton);
            this.panel2.Location = new System.Drawing.Point(22, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 100);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtdirek2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtfrom2);
            this.panel3.Controls.Add(this.txtto2);
            this.panel3.Controls.Add(this.direkfromtobutton);
            this.panel3.Location = new System.Drawing.Point(22, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 155);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.genrebutton);
            this.panel4.Location = new System.Drawing.Point(21, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 81);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.direktorbutton);
            this.panel5.Controls.Add(this.txtdirek3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(21, 531);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 80);
            this.panel5.TabIndex = 24;
            // 
            // direktorbutton
            // 
            this.direktorbutton.AutoSize = true;
            this.direktorbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.direktorbutton.Depth = 0;
            this.direktorbutton.Icon = null;
            this.direktorbutton.Location = new System.Drawing.Point(146, 32);
            this.direktorbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.direktorbutton.Name = "direktorbutton";
            this.direktorbutton.Primary = true;
            this.direktorbutton.Size = new System.Drawing.Size(88, 36);
            this.direktorbutton.TabIndex = 27;
            this.direktorbutton.Text = "Search";
            this.direktorbutton.UseVisualStyleBackColor = true;
            this.direktorbutton.Click += new System.EventHandler(this.direktorbutton_Click);
            // 
            // txtdirek3
            // 
            this.txtdirek3.Location = new System.Drawing.Point(16, 48);
            this.txtdirek3.Name = "txtdirek3";
            this.txtdirek3.Size = new System.Drawing.Size(100, 22);
            this.txtdirek3.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Director";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Location = new System.Drawing.Point(364, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(796, 490);
            this.panel6.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gerneDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // movieDatabaseDataSet1
            // 
            this.movieDatabaseDataSet1.DataSetName = "MovieDatabaseDataSet1";
            this.movieDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.movieDatabaseDataSet1;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gerneDataGridViewTextBoxColumn
            // 
            this.gerneDataGridViewTextBoxColumn.DataPropertyName = "Gerne";
            this.gerneDataGridViewTextBoxColumn.HeaderText = "Gerne";
            this.gerneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gerneDataGridViewTextBoxColumn.Name = "gerneDataGridViewTextBoxColumn";
            this.gerneDataGridViewTextBoxColumn.Width = 125;
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            this.directorDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 643);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FilterForm";
            this.Text = "Movie Filter";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtyear;
        private MaterialSkin.Controls.MaterialRaisedButton yearbutton;
        private System.Windows.Forms.TextBox txtfrom1;
        private System.Windows.Forms.TextBox txtto1;
        private MaterialSkin.Controls.MaterialRaisedButton fromtobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdirek2;
        private System.Windows.Forms.TextBox txtfrom2;
        private System.Windows.Forms.TextBox txtto2;
        private MaterialSkin.Controls.MaterialRaisedButton direkfromtobutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton genrebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialRaisedButton direktorbutton;
        private System.Windows.Forms.TextBox txtdirek3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MovieDatabaseDataSet1 movieDatabaseDataSet1;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private MovieDatabaseDataSet1TableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}