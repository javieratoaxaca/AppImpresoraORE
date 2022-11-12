namespace Impresoras.Views
{
    partial class frmAsignacion
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
            this.gcmbxPrint = new Guna.UI.WinForms.GunaComboBox();
            this.gcmbxRegion = new Guna.UI.WinForms.GunaComboBox();
            this.dtgvAssignDetails = new System.Windows.Forms.DataGridView();
            this.mthCalendar = new System.Windows.Forms.MonthCalendar();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel19 = new Guna.UI.WinForms.GunaLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtBuscarODP = new Guna.UI.WinForms.GunaTextBox();
            this.gcmbRegion = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gLblItem = new Guna.UI.WinForms.GunaLabel();
            this.gLblFecha = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gLblEquipoSerie = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gLblId = new Guna.UI.WinForms.GunaLabel();
            this.gLblIdRegion = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gLblItemRegion = new Guna.UI.WinForms.GunaLabel();
            this.gBtnGenerarExcel = new Guna.UI.WinForms.GunaButton();
            this.gbtnAssignPrint = new Guna.UI.WinForms.GunaButton();
            this.gBtnReturnPrint = new Guna.UI.WinForms.GunaButton();
            this.gBtnGenerarPdf = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAssignDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcmbxPrint
            // 
            this.gcmbxPrint.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione una Opcion"});
            this.gcmbxPrint.BackColor = System.Drawing.Color.Transparent;
            this.gcmbxPrint.BaseColor = System.Drawing.Color.White;
            this.gcmbxPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gcmbxPrint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbxPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbxPrint.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbxPrint.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.gcmbxPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxPrint.FormattingEnabled = true;
            this.gcmbxPrint.Location = new System.Drawing.Point(80, 104);
            this.gcmbxPrint.Name = "gcmbxPrint";
            this.gcmbxPrint.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbxPrint.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxPrint.Radius = 15;
            this.gcmbxPrint.Size = new System.Drawing.Size(406, 30);
            this.gcmbxPrint.TabIndex = 26;
            this.gcmbxPrint.SelectedIndexChanged += new System.EventHandler(this.gcmbxPrint_SelectedIndexChanged);
            // 
            // gcmbxRegion
            // 
            this.gcmbxRegion.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccione una Opcion"});
            this.gcmbxRegion.BackColor = System.Drawing.Color.Transparent;
            this.gcmbxRegion.BaseColor = System.Drawing.Color.White;
            this.gcmbxRegion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gcmbxRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcmbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcmbxRegion.FocusedColor = System.Drawing.Color.Empty;
            this.gcmbxRegion.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.gcmbxRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxRegion.FormattingEnabled = true;
            this.gcmbxRegion.Location = new System.Drawing.Point(79, 223);
            this.gcmbxRegion.Name = "gcmbxRegion";
            this.gcmbxRegion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbxRegion.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxRegion.Radius = 15;
            this.gcmbxRegion.Size = new System.Drawing.Size(408, 30);
            this.gcmbxRegion.TabIndex = 28;
            this.gcmbxRegion.SelectedIndexChanged += new System.EventHandler(this.gcmbxRegion_SelectedIndexChanged);
            // 
            // dtgvAssignDetails
            // 
            this.dtgvAssignDetails.AllowUserToAddRows = false;
            this.dtgvAssignDetails.AllowUserToDeleteRows = false;
            this.dtgvAssignDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAssignDetails.Location = new System.Drawing.Point(37, 294);
            this.dtgvAssignDetails.Name = "dtgvAssignDetails";
            this.dtgvAssignDetails.ReadOnly = true;
            this.dtgvAssignDetails.Size = new System.Drawing.Size(872, 402);
            this.dtgvAssignDetails.TabIndex = 29;
            this.dtgvAssignDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAssignDetails_CellClick);
            // 
            // mthCalendar
            // 
            this.mthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mthCalendar.Location = new System.Drawing.Point(571, 104);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 0;
            this.mthCalendar.TrailingForeColor = System.Drawing.Color.LightGray;
            this.mthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel1.Location = new System.Drawing.Point(122, 68);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel1.TabIndex = 53;
            this.gunaLabel1.Text = "Impresora:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel2.Location = new System.Drawing.Point(177, 195);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 25);
            this.gunaLabel2.TabIndex = 54;
            this.gunaLabel2.Text = "Sare:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel3.Location = new System.Drawing.Point(560, 55);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(215, 25);
            this.gunaLabel3.TabIndex = 55;
            this.gunaLabel3.Text = "Seleccionar Fecha:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel19);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 47);
            this.panel1.TabIndex = 56;
            // 
            // gunaLabel19
            // 
            this.gunaLabel19.AutoSize = true;
            this.gunaLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel19.Location = new System.Drawing.Point(274, 9);
            this.gunaLabel19.Name = "gunaLabel19";
            this.gunaLabel19.Size = new System.Drawing.Size(664, 25);
            this.gunaLabel19.TabIndex = 89;
            this.gunaLabel19.Text = "ASIGNACION IMPRESORA A SEDE DE ATENCION REGIONAL";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gunaLabel18);
            this.panel3.Controls.Add(this.gunaLabel5);
            this.panel3.Controls.Add(this.gTxtBuscarODP);
            this.panel3.Controls.Add(this.gcmbRegion);
            this.panel3.Controls.Add(this.gunaLabel4);
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1214, 721);
            this.panel3.TabIndex = 1;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel18.Location = new System.Drawing.Point(537, 348);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(141, 25);
            this.gunaLabel18.TabIndex = 72;
            this.gunaLabel18.Text = "Nom. SARE:";
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
            this.gTxtBuscarODP.Font = new System.Drawing.Font("Calibri", 14F);
            this.gTxtBuscarODP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscarODP.Location = new System.Drawing.Point(394, 72);
            this.gTxtBuscarODP.Name = "gTxtBuscarODP";
            this.gTxtBuscarODP.PasswordChar = '\0';
            this.gTxtBuscarODP.Radius = 15;
            this.gTxtBuscarODP.SelectedText = "";
            this.gTxtBuscarODP.Size = new System.Drawing.Size(455, 45);
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
            this.gcmbRegion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gcmbRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbRegion.FormattingEnabled = true;
            this.gcmbRegion.Items.AddRange(new object[] {
            "Selecciona una Region:"});
            this.gcmbRegion.Location = new System.Drawing.Point(394, 36);
            this.gcmbRegion.Name = "gcmbRegion";
            this.gcmbRegion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbRegion.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbRegion.Radius = 15;
            this.gcmbRegion.Size = new System.Drawing.Size(455, 28);
            this.gcmbRegion.TabIndex = 30;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel4.Location = new System.Drawing.Point(274, 36);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel4.TabIndex = 29;
            this.gunaLabel4.Text = "FILTRO:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 742);
            this.panel2.TabIndex = 3;
            // 
            // gLblItem
            // 
            this.gLblItem.AutoSize = true;
            this.gLblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblItem.ForeColor = System.Drawing.Color.Black;
            this.gLblItem.Location = new System.Drawing.Point(75, 60);
            this.gLblItem.Name = "gLblItem";
            this.gLblItem.Size = new System.Drawing.Size(0, 25);
            this.gLblItem.TabIndex = 58;
            this.gLblItem.Visible = false;
            // 
            // gLblFecha
            // 
            this.gLblFecha.AutoSize = true;
            this.gLblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblFecha.ForeColor = System.Drawing.Color.Black;
            this.gLblFecha.Location = new System.Drawing.Point(787, 55);
            this.gLblFecha.Name = "gLblFecha";
            this.gLblFecha.Size = new System.Drawing.Size(0, 25);
            this.gLblFecha.TabIndex = 59;
            this.gLblFecha.Visible = false;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(781, 55);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(0, 25);
            this.gunaLabel6.TabIndex = 61;
            this.gunaLabel6.Visible = false;
            // 
            // gLblEquipoSerie
            // 
            this.gLblEquipoSerie.AutoSize = true;
            this.gLblEquipoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblEquipoSerie.ForeColor = System.Drawing.Color.Black;
            this.gLblEquipoSerie.Location = new System.Drawing.Point(12, 309);
            this.gLblEquipoSerie.Name = "gLblEquipoSerie";
            this.gLblEquipoSerie.Size = new System.Drawing.Size(0, 25);
            this.gLblEquipoSerie.TabIndex = 62;
            this.gLblEquipoSerie.Visible = false;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel7.Location = new System.Drawing.Point(12, 60);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(63, 25);
            this.gunaLabel7.TabIndex = 63;
            this.gunaLabel7.Text = "Item:";
            this.gunaLabel7.Visible = false;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel8.Location = new System.Drawing.Point(12, 86);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(38, 25);
            this.gunaLabel8.TabIndex = 64;
            this.gunaLabel8.Text = "Id:";
            this.gunaLabel8.Visible = false;
            // 
            // gLblId
            // 
            this.gLblId.AutoSize = true;
            this.gLblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblId.ForeColor = System.Drawing.Color.Black;
            this.gLblId.Location = new System.Drawing.Point(56, 86);
            this.gLblId.Name = "gLblId";
            this.gLblId.Size = new System.Drawing.Size(0, 25);
            this.gLblId.TabIndex = 65;
            this.gLblId.Visible = false;
            // 
            // gLblIdRegion
            // 
            this.gLblIdRegion.AutoSize = true;
            this.gLblIdRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblIdRegion.ForeColor = System.Drawing.Color.Black;
            this.gLblIdRegion.Location = new System.Drawing.Point(56, 267);
            this.gLblIdRegion.Name = "gLblIdRegion";
            this.gLblIdRegion.Size = new System.Drawing.Size(0, 25);
            this.gLblIdRegion.TabIndex = 69;
            this.gLblIdRegion.Visible = false;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel10.Location = new System.Drawing.Point(12, 267);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(38, 25);
            this.gunaLabel10.TabIndex = 68;
            this.gunaLabel10.Text = "Id:";
            this.gunaLabel10.Visible = false;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel11.Location = new System.Drawing.Point(12, 216);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(63, 25);
            this.gunaLabel11.TabIndex = 67;
            this.gunaLabel11.Text = "Item:";
            this.gunaLabel11.Visible = false;
            // 
            // gLblItemRegion
            // 
            this.gLblItemRegion.AutoSize = true;
            this.gLblItemRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblItemRegion.ForeColor = System.Drawing.Color.Black;
            this.gLblItemRegion.Location = new System.Drawing.Point(81, 216);
            this.gLblItemRegion.Name = "gLblItemRegion";
            this.gLblItemRegion.Size = new System.Drawing.Size(0, 25);
            this.gLblItemRegion.TabIndex = 66;
            this.gLblItemRegion.Visible = false;
            // 
            // gBtnGenerarExcel
            // 
            this.gBtnGenerarExcel.AnimationHoverSpeed = 0.07F;
            this.gBtnGenerarExcel.AnimationSpeed = 0.03F;
            this.gBtnGenerarExcel.BackColor = System.Drawing.Color.Transparent;
            this.gBtnGenerarExcel.BaseColor = System.Drawing.Color.White;
            this.gBtnGenerarExcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnGenerarExcel.BorderSize = 2;
            this.gBtnGenerarExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnGenerarExcel.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnGenerarExcel.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnGenerarExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGenerarExcel.Image = global::Impresoras.Properties.Resources.icons8_xls_export_48px;
            this.gBtnGenerarExcel.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnGenerarExcel.Location = new System.Drawing.Point(932, 384);
            this.gBtnGenerarExcel.Name = "gBtnGenerarExcel";
            this.gBtnGenerarExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnGenerarExcel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGenerarExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnGenerarExcel.OnHoverImage = null;
            this.gBtnGenerarExcel.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnGenerarExcel.Radius = 10;
            this.gBtnGenerarExcel.Size = new System.Drawing.Size(239, 71);
            this.gBtnGenerarExcel.TabIndex = 57;
            this.gBtnGenerarExcel.Text = "Generar Excel";
            // 
            // gbtnAssignPrint
            // 
            this.gbtnAssignPrint.AnimationHoverSpeed = 0.07F;
            this.gbtnAssignPrint.AnimationSpeed = 0.03F;
            this.gbtnAssignPrint.BackColor = System.Drawing.Color.Transparent;
            this.gbtnAssignPrint.BaseColor = System.Drawing.Color.White;
            this.gbtnAssignPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnAssignPrint.BorderSize = 2;
            this.gbtnAssignPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnAssignPrint.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnAssignPrint.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnAssignPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnAssignPrint.Image = global::Impresoras.Properties.Resources.icons8_task_48px;
            this.gbtnAssignPrint.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnAssignPrint.Location = new System.Drawing.Point(932, 104);
            this.gbtnAssignPrint.Name = "gbtnAssignPrint";
            this.gbtnAssignPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnAssignPrint.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnAssignPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAssignPrint.OnHoverImage = null;
            this.gbtnAssignPrint.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnAssignPrint.Radius = 10;
            this.gbtnAssignPrint.Size = new System.Drawing.Size(239, 72);
            this.gbtnAssignPrint.TabIndex = 27;
            this.gbtnAssignPrint.Text = "Asignar Impresora";
            this.gbtnAssignPrint.Click += new System.EventHandler(this.gbtnAssignPrint_Click);
            // 
            // gBtnReturnPrint
            // 
            this.gBtnReturnPrint.AnimationHoverSpeed = 0.07F;
            this.gBtnReturnPrint.AnimationSpeed = 0.03F;
            this.gBtnReturnPrint.BackColor = System.Drawing.Color.Transparent;
            this.gBtnReturnPrint.BaseColor = System.Drawing.Color.White;
            this.gBtnReturnPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnReturnPrint.BorderSize = 2;
            this.gBtnReturnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnReturnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnReturnPrint.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnReturnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnReturnPrint.Image = global::Impresoras.Properties.Resources.icons8_return_book_60px;
            this.gBtnReturnPrint.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnReturnPrint.Location = new System.Drawing.Point(932, 195);
            this.gBtnReturnPrint.Name = "gBtnReturnPrint";
            this.gBtnReturnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnReturnPrint.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnReturnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnReturnPrint.OnHoverImage = null;
            this.gBtnReturnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnReturnPrint.Radius = 10;
            this.gBtnReturnPrint.Size = new System.Drawing.Size(239, 71);
            this.gBtnReturnPrint.TabIndex = 25;
            this.gBtnReturnPrint.Text = "Devolucion Impresora";
            this.gBtnReturnPrint.Click += new System.EventHandler(this.gBtnReturnPrint_Click);
            // 
            // gBtnGenerarPdf
            // 
            this.gBtnGenerarPdf.AnimationHoverSpeed = 0.07F;
            this.gBtnGenerarPdf.AnimationSpeed = 0.03F;
            this.gBtnGenerarPdf.BackColor = System.Drawing.Color.Transparent;
            this.gBtnGenerarPdf.BaseColor = System.Drawing.Color.White;
            this.gBtnGenerarPdf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnGenerarPdf.BorderSize = 2;
            this.gBtnGenerarPdf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnGenerarPdf.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnGenerarPdf.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnGenerarPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGenerarPdf.Image = global::Impresoras.Properties.Resources.icons8_export_pdf_60px;
            this.gBtnGenerarPdf.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnGenerarPdf.Location = new System.Drawing.Point(932, 291);
            this.gBtnGenerarPdf.Name = "gBtnGenerarPdf";
            this.gBtnGenerarPdf.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnGenerarPdf.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGenerarPdf.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnGenerarPdf.OnHoverImage = null;
            this.gBtnGenerarPdf.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnGenerarPdf.Radius = 10;
            this.gBtnGenerarPdf.Size = new System.Drawing.Size(239, 71);
            this.gBtnGenerarPdf.TabIndex = 24;
            this.gBtnGenerarPdf.Text = "Generar Pdf";
            this.gBtnGenerarPdf.Click += new System.EventHandler(this.gBtnGenerarPdf_Click);
            // 
            // frmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1270, 715);
            this.Controls.Add(this.gLblIdRegion);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gLblItemRegion);
            this.Controls.Add(this.gLblId);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gLblEquipoSerie);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gLblFecha);
            this.Controls.Add(this.gLblItem);
            this.Controls.Add(this.gBtnGenerarExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.mthCalendar);
            this.Controls.Add(this.dtgvAssignDetails);
            this.Controls.Add(this.gcmbxRegion);
            this.Controls.Add(this.gbtnAssignPrint);
            this.Controls.Add(this.gcmbxPrint);
            this.Controls.Add(this.gBtnReturnPrint);
            this.Controls.Add(this.gBtnGenerarPdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsignacion";
            this.Text = "frmAsignacion";
            this.Load += new System.EventHandler(this.frmAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAssignDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox gcmbxPrint;
        private Guna.UI.WinForms.GunaButton gBtnReturnPrint;
        private Guna.UI.WinForms.GunaButton gBtnGenerarPdf;
        private Guna.UI.WinForms.GunaButton gbtnAssignPrint;
        private Guna.UI.WinForms.GunaComboBox gcmbxRegion;
        private System.Windows.Forms.DataGridView dtgvAssignDetails;
        private System.Windows.Forms.MonthCalendar mthCalendar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel19;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox gTxtBuscarODP;
        private Guna.UI.WinForms.GunaComboBox gcmbRegion;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton gBtnGenerarExcel;
        private Guna.UI.WinForms.GunaLabel gLblItem;
        private Guna.UI.WinForms.GunaLabel gLblFecha;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gLblEquipoSerie;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gLblId;
        private Guna.UI.WinForms.GunaLabel gLblIdRegion;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gLblItemRegion;
    }
}