namespace BulanikMantik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSol = new Panel();
            lvwMamdani = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label4 = new Label();
            lstKurallar = new ListBox();
            btnHesapla = new Button();
            grpGiris = new GroupBox();
            nudKirlilik = new NumericUpDown();
            nudMiktar = new NumericUpDown();
            nudHassaslik = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbHassaslik = new PictureBox();
            pbMiktar = new PictureBox();
            pbKirlilik = new PictureBox();
            tabPage2 = new TabPage();
            dgvKurallar = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Hassaslık = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Kirlilik = new DataGridViewTextBoxColumn();
            DönüşHızı = new DataGridViewTextBoxColumn();
            Süre = new DataGridViewTextBoxColumn();
            Deterjan = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            lblDegerHiz = new Label();
            lblBaslikHiz = new Label();
            panel2 = new Panel();
            lblDegerSure = new Label();
            lblBaslikSure = new Label();
            panel3 = new Panel();
            lblDegerDet = new Label();
            lblBaslikDet = new Label();
            pbSonucGrafik = new PictureBox();
            panelSol.SuspendLayout();
            grpGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKirlilik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHassaslik).BeginInit();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHassaslik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKirlilik).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKurallar).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSonucGrafik).BeginInit();
            SuspendLayout();
            // 
            // panelSol
            // 
            panelSol.Controls.Add(lvwMamdani);
            panelSol.Controls.Add(label4);
            panelSol.Controls.Add(lstKurallar);
            panelSol.Controls.Add(btnHesapla);
            panelSol.Controls.Add(grpGiris);
            panelSol.Dock = DockStyle.Left;
            panelSol.Location = new Point(0, 0);
            panelSol.Name = "panelSol";
            panelSol.Size = new Size(250, 538);
            panelSol.TabIndex = 0;
            // 
            // lvwMamdani
            // 
            lvwMamdani.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvwMamdani.Dock = DockStyle.Fill;
            lvwMamdani.Location = new Point(0, 308);
            lvwMamdani.Name = "lvwMamdani";
            lvwMamdani.Size = new Size(250, 230);
            lvwMamdani.TabIndex = 4;
            lvwMamdani.UseCompatibleStateImageBehavior = false;
            lvwMamdani.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "α";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 278);
            label4.Name = "label4";
            label4.Size = new Size(250, 30);
            label4.TabIndex = 3;
            label4.Text = "Değerler";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstKurallar
            // 
            lstKurallar.Dock = DockStyle.Top;
            lstKurallar.FormattingEnabled = true;
            lstKurallar.ItemHeight = 15;
            lstKurallar.Location = new Point(0, 154);
            lstKurallar.Name = "lstKurallar";
            lstKurallar.Size = new Size(250, 124);
            lstKurallar.TabIndex = 2;
            // 
            // btnHesapla
            // 
            btnHesapla.Dock = DockStyle.Top;
            btnHesapla.Location = new Point(0, 120);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(250, 34);
            btnHesapla.TabIndex = 1;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // grpGiris
            // 
            grpGiris.Controls.Add(nudKirlilik);
            grpGiris.Controls.Add(nudMiktar);
            grpGiris.Controls.Add(nudHassaslik);
            grpGiris.Controls.Add(label3);
            grpGiris.Controls.Add(label2);
            grpGiris.Controls.Add(label1);
            grpGiris.Dock = DockStyle.Top;
            grpGiris.Location = new Point(0, 0);
            grpGiris.Name = "grpGiris";
            grpGiris.Padding = new Padding(10);
            grpGiris.Size = new Size(250, 120);
            grpGiris.TabIndex = 0;
            grpGiris.TabStop = false;
            grpGiris.Text = "Giriş Değerleri";
            // 
            // nudKirlilik
            // 
            nudKirlilik.DecimalPlaces = 2;
            nudKirlilik.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nudKirlilik.Location = new Point(137, 82);
            nudKirlilik.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudKirlilik.Name = "nudKirlilik";
            nudKirlilik.Size = new Size(60, 23);
            nudKirlilik.TabIndex = 5;
            // 
            // nudMiktar
            // 
            nudMiktar.DecimalPlaces = 2;
            nudMiktar.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nudMiktar.Location = new Point(137, 53);
            nudMiktar.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(60, 23);
            nudMiktar.TabIndex = 4;
            // 
            // nudHassaslik
            // 
            nudHassaslik.DecimalPlaces = 2;
            nudHassaslik.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            nudHassaslik.Location = new Point(137, 26);
            nudHassaslik.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudHassaslik.Name = "nudHassaslik";
            nudHassaslik.Size = new Size(60, 23);
            nudHassaslik.TabIndex = 3;
            nudHassaslik.ValueChanged += nudHassaslik_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 85);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Kirlilik =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Miktar =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Hassaslık =";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage3);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(250, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(661, 538);
            tabControlMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(653, 510);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Grafikler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pbHassaslik, 0, 0);
            tableLayoutPanel1.Controls.Add(pbMiktar, 0, 1);
            tableLayoutPanel1.Controls.Add(pbKirlilik, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(647, 504);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pbHassaslik
            // 
            pbHassaslik.BackColor = Color.White;
            pbHassaslik.Dock = DockStyle.Fill;
            pbHassaslik.Location = new Point(3, 3);
            pbHassaslik.Name = "pbHassaslik";
            pbHassaslik.Size = new Size(641, 162);
            pbHassaslik.TabIndex = 0;
            pbHassaslik.TabStop = false;
            pbHassaslik.Paint += pbHassaslik_Paint;
            // 
            // pbMiktar
            // 
            pbMiktar.BackColor = Color.White;
            pbMiktar.Dock = DockStyle.Fill;
            pbMiktar.Location = new Point(3, 171);
            pbMiktar.Name = "pbMiktar";
            pbMiktar.Size = new Size(641, 162);
            pbMiktar.TabIndex = 1;
            pbMiktar.TabStop = false;
            pbMiktar.Paint += pbMiktar_Paint;
            // 
            // pbKirlilik
            // 
            pbKirlilik.BackColor = Color.White;
            pbKirlilik.Dock = DockStyle.Fill;
            pbKirlilik.Location = new Point(3, 339);
            pbKirlilik.Name = "pbKirlilik";
            pbKirlilik.Size = new Size(641, 162);
            pbKirlilik.TabIndex = 2;
            pbKirlilik.TabStop = false;
            pbKirlilik.Paint += pbKirlilik_Paint;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvKurallar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(653, 510);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kurallar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvKurallar
            // 
            dgvKurallar.AllowUserToAddRows = false;
            dgvKurallar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKurallar.Columns.AddRange(new DataGridViewColumn[] { No, Hassaslık, Miktar, Kirlilik, DönüşHızı, Süre, Deterjan });
            dgvKurallar.Dock = DockStyle.Fill;
            dgvKurallar.Location = new Point(3, 3);
            dgvKurallar.Name = "dgvKurallar";
            dgvKurallar.ReadOnly = true;
            dgvKurallar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKurallar.Size = new Size(647, 504);
            dgvKurallar.TabIndex = 0;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.Name = "No";
            No.ReadOnly = true;
            // 
            // Hassaslık
            // 
            Hassaslık.HeaderText = "Hassaslık";
            Hassaslık.Name = "Hassaslık";
            Hassaslık.ReadOnly = true;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            // 
            // Kirlilik
            // 
            Kirlilik.HeaderText = "Kirlilik";
            Kirlilik.Name = "Kirlilik";
            Kirlilik.ReadOnly = true;
            // 
            // DönüşHızı
            // 
            DönüşHızı.HeaderText = "Dönüş Hızı";
            DönüşHızı.Name = "DönüşHızı";
            DönüşHızı.ReadOnly = true;
            // 
            // Süre
            // 
            Süre.HeaderText = "Süre";
            Süre.Name = "Süre";
            Süre.ReadOnly = true;
            // 
            // Deterjan
            // 
            Deterjan.HeaderText = "Deterjan";
            Deterjan.Name = "Deterjan";
            Deterjan.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(653, 510);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sonuçlar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(pbSonucGrafik, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.01923F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.98077F));
            tableLayoutPanel2.Size = new Size(647, 504);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(panel2, 1, 0);
            tableLayoutPanel3.Controls.Add(panel3, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(641, 180);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDegerHiz);
            panel1.Controls.Add(lblBaslikHiz);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 174);
            panel1.TabIndex = 0;
            // 
            // lblDegerHiz
            // 
            lblDegerHiz.Dock = DockStyle.Fill;
            lblDegerHiz.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDegerHiz.ForeColor = Color.DarkBlue;
            lblDegerHiz.Location = new Point(0, 31);
            lblDegerHiz.Name = "lblDegerHiz";
            lblDegerHiz.Size = new Size(207, 143);
            lblDegerHiz.TabIndex = 1;
            lblDegerHiz.Text = "?";
            lblDegerHiz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBaslikHiz
            // 
            lblBaslikHiz.Dock = DockStyle.Top;
            lblBaslikHiz.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslikHiz.Location = new Point(0, 0);
            lblBaslikHiz.Margin = new Padding(3);
            lblBaslikHiz.Name = "lblBaslikHiz";
            lblBaslikHiz.Size = new Size(207, 31);
            lblBaslikHiz.TabIndex = 0;
            lblBaslikHiz.Text = "Dönüş Hızı";
            lblBaslikHiz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDegerSure);
            panel2.Controls.Add(lblBaslikSure);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(216, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 174);
            panel2.TabIndex = 1;
            // 
            // lblDegerSure
            // 
            lblDegerSure.Dock = DockStyle.Fill;
            lblDegerSure.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDegerSure.ForeColor = Color.DarkGreen;
            lblDegerSure.Location = new Point(0, 31);
            lblDegerSure.Name = "lblDegerSure";
            lblDegerSure.Size = new Size(207, 143);
            lblDegerSure.TabIndex = 1;
            lblDegerSure.Text = "?";
            lblDegerSure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBaslikSure
            // 
            lblBaslikSure.Dock = DockStyle.Top;
            lblBaslikSure.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslikSure.Location = new Point(0, 0);
            lblBaslikSure.Margin = new Padding(3);
            lblBaslikSure.Name = "lblBaslikSure";
            lblBaslikSure.Size = new Size(207, 31);
            lblBaslikSure.TabIndex = 0;
            lblBaslikSure.Text = "Süre";
            lblBaslikSure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDegerDet);
            panel3.Controls.Add(lblBaslikDet);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(429, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 174);
            panel3.TabIndex = 2;
            // 
            // lblDegerDet
            // 
            lblDegerDet.Dock = DockStyle.Fill;
            lblDegerDet.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDegerDet.ForeColor = Color.DarkRed;
            lblDegerDet.Location = new Point(0, 31);
            lblDegerDet.Name = "lblDegerDet";
            lblDegerDet.Size = new Size(209, 143);
            lblDegerDet.TabIndex = 1;
            lblDegerDet.Text = "?";
            lblDegerDet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBaslikDet
            // 
            lblBaslikDet.Dock = DockStyle.Top;
            lblBaslikDet.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslikDet.Location = new Point(0, 0);
            lblBaslikDet.Margin = new Padding(3);
            lblBaslikDet.Name = "lblBaslikDet";
            lblBaslikDet.Size = new Size(209, 31);
            lblBaslikDet.TabIndex = 0;
            lblBaslikDet.Text = "Deterjan";
            lblBaslikDet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSonucGrafik
            // 
            pbSonucGrafik.BackColor = Color.White;
            pbSonucGrafik.Dock = DockStyle.Fill;
            pbSonucGrafik.Location = new Point(3, 189);
            pbSonucGrafik.Name = "pbSonucGrafik";
            pbSonucGrafik.Size = new Size(641, 312);
            pbSonucGrafik.TabIndex = 1;
            pbSonucGrafik.TabStop = false;
            pbSonucGrafik.Paint += pbSonucGrafik_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 538);
            Controls.Add(tabControlMain);
            Controls.Add(panelSol);
            Name = "Form1";
            Text = "Form1";
            panelSol.ResumeLayout(false);
            grpGiris.ResumeLayout(false);
            grpGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKirlilik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHassaslik).EndInit();
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHassaslik).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKirlilik).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKurallar).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSonucGrafik).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSol;
        private GroupBox grpGiris;
        private Label label4;
        private ListBox lstKurallar;
        private Button btnHesapla;
        private NumericUpDown nudKirlilik;
        private NumericUpDown nudMiktar;
        private NumericUpDown nudHassaslik;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbHassaslik;
        private PictureBox pbMiktar;
        private PictureBox pbKirlilik;
        private TabPage tabPage2;
        private DataGridView dgvKurallar;
        private TabPage tabPage3;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Hassaslık;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Kirlilik;
        private DataGridViewTextBoxColumn DönüşHızı;
        private DataGridViewTextBoxColumn Süre;
        private DataGridViewTextBoxColumn Deterjan;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Label lblDegerHiz;
        private Label lblBaslikHiz;
        private Panel panel2;
        private Label lblDegerSure;
        private Label lblBaslikSure;
        private Panel panel3;
        private Label lblBaslikDet;
        private Label lblDegerDet;
        private PictureBox pbSonucGrafik;
        private ListView lvwMamdani;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
