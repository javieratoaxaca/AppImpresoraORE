namespace Impresoras.Views
{
    partial class frmPrintUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtBuscarODP = new Guna.UI.WinForms.GunaTextBox();
            this.gcmbRegion = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsnDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtNoEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtNomEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.gTxtSerieEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.gTxtMarcaEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.gTxtModeloEquipo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.pctQr = new System.Windows.Forms.PictureBox();
            this.gBtnQrDispositivo = new Guna.UI.WinForms.GunaButton();
            this.gBtnEliminarDispositivo = new Guna.UI.WinForms.GunaButton();
            this.gBtnEditarDispositivo = new Guna.UI.WinForms.GunaButton();
            this.gBtnRegistrarDispositivo = new Guna.UI.WinForms.GunaButton();
            this.gBtnGuardarDispositivo = new Guna.UI.WinForms.GunaButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gunaLabel5);
            this.panel3.Controls.Add(this.gTxtBuscarODP);
            this.panel3.Controls.Add(this.gcmbRegion);
            this.panel3.Controls.Add(this.gunaLabel2);
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1214, 721);
            this.panel3.TabIndex = 1;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel5.Location = new System.Drawing.Point(274, 80);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(112, 25);
            this.gunaLabel5.TabIndex = 32;
            this.gunaLabel5.Text = "BUSCAR:";
            // 
            // gTxtBuscarODP
            // 
            this.gTxtBuscarODP.BackColor = System.Drawing.Color.Transparent;
            this.gTxtBuscarODP.BaseColor = System.Drawing.Color.White;
            this.gTxtBuscarODP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtBuscarODP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtBuscarODP.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtBuscarODP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtBuscarODP.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscarODP.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtBuscarODP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscarODP.Location = new System.Drawing.Point(394, 72);
            this.gTxtBuscarODP.Name = "gTxtBuscarODP";
            this.gTxtBuscarODP.PasswordChar = '\0';
            this.gTxtBuscarODP.Radius = 15;
            this.gTxtBuscarODP.SelectedText = "";
            this.gTxtBuscarODP.Size = new System.Drawing.Size(455, 41);
            this.gTxtBuscarODP.TabIndex = 31;
            // 
            // gcmbRegion
            // 
            this.gcmbRegion.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione una Opcion"});
            this.gcmbRegion.BackColor = System.Drawing.Color.Transparent;
            this.gcmbRegion.BaseColor = System.Drawing.Color.White;
            this.gcmbRegion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gcmbRegion.BorderSize = 1;
            this.gcmbRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbRegion.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbRegion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gcmbRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbRegion.FormattingEnabled = true;
            this.gcmbRegion.Items.AddRange(new object[] {
            "Selecciona una Region:"});
            this.gcmbRegion.Location = new System.Drawing.Point(394, 36);
            this.gcmbRegion.Name = "gcmbRegion";
            this.gcmbRegion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbRegion.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbRegion.Radius = 15;
            this.gcmbRegion.Size = new System.Drawing.Size(455, 30);
            this.gcmbRegion.TabIndex = 30;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel2.Location = new System.Drawing.Point(274, 36);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel2.TabIndex = 29;
            this.gunaLabel2.Text = "FILTRO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMsnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 47);
            this.panel1.TabIndex = 4;
            // 
            // lblMsnDashboard
            // 
            this.lblMsnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsnDashboard.AutoSize = true;
            this.lblMsnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsnDashboard.Location = new System.Drawing.Point(445, 5);
            this.lblMsnDashboard.Name = "lblMsnDashboard";
            this.lblMsnDashboard.Size = new System.Drawing.Size(302, 39);
            this.lblMsnDashboard.TabIndex = 1;
            this.lblMsnDashboard.Text = "Alta de Impresoras";
            this.lblMsnDashboard.Click += new System.EventHandler(this.lblMsnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 742);
            this.panel2.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel1.Location = new System.Drawing.Point(72, 99);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(128, 25);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "No.Equipo:";
            // 
            // gTxtNoEquipo
            // 
            this.gTxtNoEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gTxtNoEquipo.BaseColor = System.Drawing.Color.White;
            this.gTxtNoEquipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtNoEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtNoEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtNoEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtNoEquipo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtNoEquipo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtNoEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtNoEquipo.Location = new System.Drawing.Point(216, 83);
            this.gTxtNoEquipo.Name = "gTxtNoEquipo";
            this.gTxtNoEquipo.PasswordChar = '\0';
            this.gTxtNoEquipo.Radius = 15;
            this.gTxtNoEquipo.SelectedText = "";
            this.gTxtNoEquipo.Size = new System.Drawing.Size(296, 50);
            this.gTxtNoEquipo.TabIndex = 28;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel3.Location = new System.Drawing.Point(46, 256);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(154, 25);
            this.gunaLabel3.TabIndex = 30;
            this.gunaLabel3.Text = "Serie Equipo:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel4.Location = new System.Drawing.Point(47, 175);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(153, 25);
            this.gunaLabel4.TabIndex = 31;
            this.gunaLabel4.Text = "Nom. Equipo:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel6.Location = new System.Drawing.Point(24, 417);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(176, 25);
            this.gunaLabel6.TabIndex = 32;
            this.gunaLabel6.Text = "Modelo Equipo:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel7.Location = new System.Drawing.Point(36, 339);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(164, 25);
            this.gunaLabel7.TabIndex = 33;
            this.gunaLabel7.Text = "Marca Equipo:";
            // 
            // gTxtNomEquipo
            // 
            this.gTxtNomEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gTxtNomEquipo.BaseColor = System.Drawing.Color.White;
            this.gTxtNomEquipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtNomEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtNomEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtNomEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtNomEquipo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtNomEquipo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtNomEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtNomEquipo.Location = new System.Drawing.Point(216, 159);
            this.gTxtNomEquipo.Name = "gTxtNomEquipo";
            this.gTxtNomEquipo.PasswordChar = '\0';
            this.gTxtNomEquipo.Radius = 15;
            this.gTxtNomEquipo.SelectedText = "";
            this.gTxtNomEquipo.Size = new System.Drawing.Size(296, 50);
            this.gTxtNomEquipo.TabIndex = 34;
            // 
            // gTxtSerieEquipo
            // 
            this.gTxtSerieEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gTxtSerieEquipo.BaseColor = System.Drawing.Color.White;
            this.gTxtSerieEquipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtSerieEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtSerieEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtSerieEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtSerieEquipo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtSerieEquipo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtSerieEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtSerieEquipo.Location = new System.Drawing.Point(216, 240);
            this.gTxtSerieEquipo.Name = "gTxtSerieEquipo";
            this.gTxtSerieEquipo.PasswordChar = '\0';
            this.gTxtSerieEquipo.Radius = 15;
            this.gTxtSerieEquipo.SelectedText = "";
            this.gTxtSerieEquipo.Size = new System.Drawing.Size(296, 50);
            this.gTxtSerieEquipo.TabIndex = 35;
            // 
            // gTxtMarcaEquipo
            // 
            this.gTxtMarcaEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gTxtMarcaEquipo.BaseColor = System.Drawing.Color.White;
            this.gTxtMarcaEquipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtMarcaEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtMarcaEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtMarcaEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtMarcaEquipo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtMarcaEquipo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtMarcaEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtMarcaEquipo.Location = new System.Drawing.Point(216, 323);
            this.gTxtMarcaEquipo.Name = "gTxtMarcaEquipo";
            this.gTxtMarcaEquipo.PasswordChar = '\0';
            this.gTxtMarcaEquipo.Radius = 15;
            this.gTxtMarcaEquipo.SelectedText = "";
            this.gTxtMarcaEquipo.Size = new System.Drawing.Size(296, 50);
            this.gTxtMarcaEquipo.TabIndex = 36;
            // 
            // gTxtModeloEquipo
            // 
            this.gTxtModeloEquipo.BackColor = System.Drawing.Color.Transparent;
            this.gTxtModeloEquipo.BaseColor = System.Drawing.Color.White;
            this.gTxtModeloEquipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtModeloEquipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtModeloEquipo.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtModeloEquipo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtModeloEquipo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtModeloEquipo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtModeloEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtModeloEquipo.Location = new System.Drawing.Point(216, 401);
            this.gTxtModeloEquipo.Name = "gTxtModeloEquipo";
            this.gTxtModeloEquipo.PasswordChar = '\0';
            this.gTxtModeloEquipo.Radius = 15;
            this.gTxtModeloEquipo.SelectedText = "";
            this.gTxtModeloEquipo.Size = new System.Drawing.Size(296, 50);
            this.gTxtModeloEquipo.TabIndex = 37;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(29, 484);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(820, 284);
            this.gunaDataGridView1.TabIndex = 43;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pctQr
            // 
            this.pctQr.Location = new System.Drawing.Point(859, 484);
            this.pctQr.Name = "pctQr";
            this.pctQr.Size = new System.Drawing.Size(346, 281);
            this.pctQr.TabIndex = 44;
            this.pctQr.TabStop = false;
            // 
            // gBtnQrDispositivo
            // 
            this.gBtnQrDispositivo.AnimationHoverSpeed = 0.07F;
            this.gBtnQrDispositivo.AnimationSpeed = 0.03F;
            this.gBtnQrDispositivo.BackColor = System.Drawing.Color.Transparent;
            this.gBtnQrDispositivo.BaseColor = System.Drawing.Color.White;
            this.gBtnQrDispositivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnQrDispositivo.BorderSize = 2;
            this.gBtnQrDispositivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnQrDispositivo.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnQrDispositivo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnQrDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnQrDispositivo.Image = global::Impresoras.Properties.Resources.icons8_qr_code_48px_1;
            this.gBtnQrDispositivo.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnQrDispositivo.Location = new System.Drawing.Point(1035, 177);
            this.gBtnQrDispositivo.Name = "gBtnQrDispositivo";
            this.gBtnQrDispositivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnQrDispositivo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnQrDispositivo.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnQrDispositivo.OnHoverImage = null;
            this.gBtnQrDispositivo.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnQrDispositivo.Radius = 10;
            this.gBtnQrDispositivo.Size = new System.Drawing.Size(170, 77);
            this.gBtnQrDispositivo.TabIndex = 42;
            this.gBtnQrDispositivo.Text = "GenerarQr";
            // 
            // gBtnEliminarDispositivo
            // 
            this.gBtnEliminarDispositivo.AnimationHoverSpeed = 0.07F;
            this.gBtnEliminarDispositivo.AnimationSpeed = 0.03F;
            this.gBtnEliminarDispositivo.BackColor = System.Drawing.Color.Transparent;
            this.gBtnEliminarDispositivo.BaseColor = System.Drawing.Color.White;
            this.gBtnEliminarDispositivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnEliminarDispositivo.BorderSize = 2;
            this.gBtnEliminarDispositivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnEliminarDispositivo.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnEliminarDispositivo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnEliminarDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnEliminarDispositivo.Image = global::Impresoras.Properties.Resources.icons8_delete_file_48px;
            this.gBtnEliminarDispositivo.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnEliminarDispositivo.Location = new System.Drawing.Point(1035, 376);
            this.gBtnEliminarDispositivo.Name = "gBtnEliminarDispositivo";
            this.gBtnEliminarDispositivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnEliminarDispositivo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnEliminarDispositivo.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnEliminarDispositivo.OnHoverImage = null;
            this.gBtnEliminarDispositivo.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnEliminarDispositivo.Radius = 10;
            this.gBtnEliminarDispositivo.Size = new System.Drawing.Size(170, 77);
            this.gBtnEliminarDispositivo.TabIndex = 41;
            this.gBtnEliminarDispositivo.Text = "Eliminar";
            // 
            // gBtnEditarDispositivo
            // 
            this.gBtnEditarDispositivo.AnimationHoverSpeed = 0.07F;
            this.gBtnEditarDispositivo.AnimationSpeed = 0.03F;
            this.gBtnEditarDispositivo.BackColor = System.Drawing.Color.Transparent;
            this.gBtnEditarDispositivo.BaseColor = System.Drawing.Color.White;
            this.gBtnEditarDispositivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnEditarDispositivo.BorderSize = 2;
            this.gBtnEditarDispositivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnEditarDispositivo.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnEditarDispositivo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnEditarDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnEditarDispositivo.Image = global::Impresoras.Properties.Resources.icons8_edit_60px;
            this.gBtnEditarDispositivo.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnEditarDispositivo.Location = new System.Drawing.Point(1035, 272);
            this.gBtnEditarDispositivo.Name = "gBtnEditarDispositivo";
            this.gBtnEditarDispositivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnEditarDispositivo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnEditarDispositivo.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnEditarDispositivo.OnHoverImage = null;
            this.gBtnEditarDispositivo.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnEditarDispositivo.Radius = 10;
            this.gBtnEditarDispositivo.Size = new System.Drawing.Size(170, 77);
            this.gBtnEditarDispositivo.TabIndex = 40;
            this.gBtnEditarDispositivo.Text = "Editar";
            // 
            // gBtnRegistrarDispositivo
            // 
            this.gBtnRegistrarDispositivo.AnimationHoverSpeed = 0.07F;
            this.gBtnRegistrarDispositivo.AnimationSpeed = 0.03F;
            this.gBtnRegistrarDispositivo.BackColor = System.Drawing.Color.Transparent;
            this.gBtnRegistrarDispositivo.BaseColor = System.Drawing.Color.White;
            this.gBtnRegistrarDispositivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnRegistrarDispositivo.BorderSize = 2;
            this.gBtnRegistrarDispositivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnRegistrarDispositivo.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnRegistrarDispositivo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnRegistrarDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnRegistrarDispositivo.Image = global::Impresoras.Properties.Resources.icons8_add_new_48px;
            this.gBtnRegistrarDispositivo.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnRegistrarDispositivo.Location = new System.Drawing.Point(1035, 75);
            this.gBtnRegistrarDispositivo.Name = "gBtnRegistrarDispositivo";
            this.gBtnRegistrarDispositivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnRegistrarDispositivo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnRegistrarDispositivo.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnRegistrarDispositivo.OnHoverImage = null;
            this.gBtnRegistrarDispositivo.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnRegistrarDispositivo.Radius = 10;
            this.gBtnRegistrarDispositivo.Size = new System.Drawing.Size(170, 77);
            this.gBtnRegistrarDispositivo.TabIndex = 38;
            this.gBtnRegistrarDispositivo.Text = "Registrar";
            this.gBtnRegistrarDispositivo.Click += new System.EventHandler(this.gBtnRegistrarDispositivo_Click);
            // 
            // gBtnGuardarDispositivo
            // 
            this.gBtnGuardarDispositivo.AnimationHoverSpeed = 0.07F;
            this.gBtnGuardarDispositivo.AnimationSpeed = 0.03F;
            this.gBtnGuardarDispositivo.BackColor = System.Drawing.Color.Transparent;
            this.gBtnGuardarDispositivo.BaseColor = System.Drawing.Color.White;
            this.gBtnGuardarDispositivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnGuardarDispositivo.BorderSize = 2;
            this.gBtnGuardarDispositivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnGuardarDispositivo.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnGuardarDispositivo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnGuardarDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGuardarDispositivo.Image = global::Impresoras.Properties.Resources.icons8_add_new_48px;
            this.gBtnGuardarDispositivo.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnGuardarDispositivo.Location = new System.Drawing.Point(1035, 75);
            this.gBtnGuardarDispositivo.Name = "gBtnGuardarDispositivo";
            this.gBtnGuardarDispositivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnGuardarDispositivo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGuardarDispositivo.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnGuardarDispositivo.OnHoverImage = null;
            this.gBtnGuardarDispositivo.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnGuardarDispositivo.Radius = 10;
            this.gBtnGuardarDispositivo.Size = new System.Drawing.Size(170, 77);
            this.gBtnGuardarDispositivo.TabIndex = 39;
            this.gBtnGuardarDispositivo.Text = "Guardar";
            // 
            // frmPrintUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1217, 804);
            this.Controls.Add(this.pctQr);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gBtnQrDispositivo);
            this.Controls.Add(this.gBtnEliminarDispositivo);
            this.Controls.Add(this.gBtnEditarDispositivo);
            this.Controls.Add(this.gBtnRegistrarDispositivo);
            this.Controls.Add(this.gTxtModeloEquipo);
            this.Controls.Add(this.gTxtMarcaEquipo);
            this.Controls.Add(this.gTxtSerieEquipo);
            this.Controls.Add(this.gTxtNomEquipo);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gTxtNoEquipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBtnGuardarDispositivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrintUp";
            this.Text = "frmPrintUp";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox gTxtBuscarODP;
        private Guna.UI.WinForms.GunaComboBox gcmbRegion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsnDashboard;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox gTxtNoEquipo;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox gTxtNomEquipo;
        private Guna.UI.WinForms.GunaTextBox gTxtSerieEquipo;
        private Guna.UI.WinForms.GunaTextBox gTxtMarcaEquipo;
        private Guna.UI.WinForms.GunaTextBox gTxtModeloEquipo;
        private Guna.UI.WinForms.GunaButton gBtnRegistrarDispositivo;
        private Guna.UI.WinForms.GunaButton gBtnGuardarDispositivo;
        private Guna.UI.WinForms.GunaButton gBtnEditarDispositivo;
        private Guna.UI.WinForms.GunaButton gBtnEliminarDispositivo;
        private Guna.UI.WinForms.GunaButton gBtnQrDispositivo;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.PictureBox pctQr;
    }
}