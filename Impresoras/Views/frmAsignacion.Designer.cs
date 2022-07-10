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
            this.dtgvArchivos = new System.Windows.Forms.DataGridView();
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
            this.gBtnGenerarExcel = new Guna.UI.WinForms.GunaButton();
            this.gbtnAssignPrint = new Guna.UI.WinForms.GunaButton();
            this.gBtnReturnPrint = new Guna.UI.WinForms.GunaButton();
            this.gBtnGenerarPdf = new Guna.UI.WinForms.GunaButton();
            this.gLbl = new Guna.UI.WinForms.GunaLabel();
            this.gLblFecha = new Guna.UI.WinForms.GunaLabel();
            this.gLblSare = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArchivos)).BeginInit();
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
            this.gcmbxPrint.Location = new System.Drawing.Point(141, 166);
            this.gcmbxPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcmbxPrint.Name = "gcmbxPrint";
            this.gcmbxPrint.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbxPrint.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxPrint.Radius = 15;
            this.gcmbxPrint.Size = new System.Drawing.Size(607, 40);
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
            this.gcmbxRegion.Location = new System.Drawing.Point(141, 320);
            this.gcmbxRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcmbxRegion.Name = "gcmbxRegion";
            this.gcmbxRegion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbxRegion.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxRegion.Radius = 15;
            this.gcmbxRegion.Size = new System.Drawing.Size(607, 40);
            this.gcmbxRegion.TabIndex = 28;
            this.gcmbxRegion.SelectedIndexChanged += new System.EventHandler(this.gcmbxRegion_SelectedIndexChanged);
            // 
            // dtgvArchivos
            // 
            this.dtgvArchivos.AllowUserToAddRows = false;
            this.dtgvArchivos.AllowUserToDeleteRows = false;
            this.dtgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArchivos.Location = new System.Drawing.Point(177, 494);
            this.dtgvArchivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvArchivos.Name = "dtgvArchivos";
            this.dtgvArchivos.ReadOnly = true;
            this.dtgvArchivos.Size = new System.Drawing.Size(1024, 292);
            this.dtgvArchivos.TabIndex = 29;
            // 
            // mthCalendar
            // 
            this.mthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mthCalendar.Location = new System.Drawing.Point(790, 160);
            this.mthCalendar.Margin = new System.Windows.Forms.Padding(14);
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
            this.gunaLabel1.Location = new System.Drawing.Point(238, 108);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(180, 37);
            this.gunaLabel1.TabIndex = 53;
            this.gunaLabel1.Text = "Impresora:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel2.Location = new System.Drawing.Point(284, 268);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(98, 37);
            this.gunaLabel2.TabIndex = 54;
            this.gunaLabel2.Text = "Sare:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel3.Location = new System.Drawing.Point(834, 108);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(180, 37);
            this.gunaLabel3.TabIndex = 55;
            this.gunaLabel3.Text = "Impresora:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel19);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1905, 72);
            this.panel1.TabIndex = 56;
            // 
            // gunaLabel19
            // 
            this.gunaLabel19.AutoSize = true;
            this.gunaLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel19.Location = new System.Drawing.Point(411, 14);
            this.gunaLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel19.Name = "gunaLabel19";
            this.gunaLabel19.Size = new System.Drawing.Size(993, 37);
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
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1821, 1109);
            this.panel3.TabIndex = 1;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel18.Location = new System.Drawing.Point(806, 535);
            this.gunaLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(209, 37);
            this.gunaLabel18.TabIndex = 72;
            this.gunaLabel18.Text = "Nom. SARE:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel5.Location = new System.Drawing.Point(411, 123);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(165, 37);
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
            this.gTxtBuscarODP.Location = new System.Drawing.Point(591, 111);
            this.gTxtBuscarODP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtBuscarODP.Name = "gTxtBuscarODP";
            this.gTxtBuscarODP.PasswordChar = '\0';
            this.gTxtBuscarODP.Radius = 15;
            this.gTxtBuscarODP.SelectedText = "";
            this.gTxtBuscarODP.Size = new System.Drawing.Size(682, 69);
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
            this.gcmbRegion.Location = new System.Drawing.Point(591, 55);
            this.gcmbRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcmbRegion.Name = "gcmbRegion";
            this.gcmbRegion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbRegion.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbRegion.Radius = 15;
            this.gcmbRegion.Size = new System.Drawing.Size(680, 38);
            this.gcmbRegion.TabIndex = 30;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel4.Location = new System.Drawing.Point(411, 55);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(146, 37);
            this.gunaLabel4.TabIndex = 29;
            this.gunaLabel4.Text = "FILTRO:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1816, 1142);
            this.panel2.TabIndex = 3;
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
            this.gBtnGenerarExcel.Location = new System.Drawing.Point(1311, 591);
            this.gBtnGenerarExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBtnGenerarExcel.Name = "gBtnGenerarExcel";
            this.gBtnGenerarExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnGenerarExcel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGenerarExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnGenerarExcel.OnHoverImage = null;
            this.gBtnGenerarExcel.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnGenerarExcel.Radius = 10;
            this.gBtnGenerarExcel.Size = new System.Drawing.Size(358, 109);
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
            this.gbtnAssignPrint.Location = new System.Drawing.Point(1311, 160);
            this.gbtnAssignPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnAssignPrint.Name = "gbtnAssignPrint";
            this.gbtnAssignPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnAssignPrint.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnAssignPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnAssignPrint.OnHoverImage = null;
            this.gbtnAssignPrint.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnAssignPrint.Radius = 10;
            this.gbtnAssignPrint.Size = new System.Drawing.Size(358, 111);
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
            this.gBtnReturnPrint.Location = new System.Drawing.Point(1311, 300);
            this.gBtnReturnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBtnReturnPrint.Name = "gBtnReturnPrint";
            this.gBtnReturnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnReturnPrint.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnReturnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnReturnPrint.OnHoverImage = null;
            this.gBtnReturnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnReturnPrint.Radius = 10;
            this.gBtnReturnPrint.Size = new System.Drawing.Size(358, 109);
            this.gBtnReturnPrint.TabIndex = 25;
            this.gBtnReturnPrint.Text = "Devolucion Impresora";
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
            this.gBtnGenerarPdf.Location = new System.Drawing.Point(1311, 448);
            this.gBtnGenerarPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBtnGenerarPdf.Name = "gBtnGenerarPdf";
            this.gBtnGenerarPdf.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnGenerarPdf.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnGenerarPdf.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnGenerarPdf.OnHoverImage = null;
            this.gBtnGenerarPdf.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnGenerarPdf.Radius = 10;
            this.gBtnGenerarPdf.Size = new System.Drawing.Size(358, 109);
            this.gBtnGenerarPdf.TabIndex = 24;
            this.gBtnGenerarPdf.Text = "Generar Pdf";
            // 
            // gLbl
            // 
            this.gLbl.AutoSize = true;
            this.gLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLbl.ForeColor = System.Drawing.Color.Black;
            this.gLbl.Location = new System.Drawing.Point(465, 108);
            this.gLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gLbl.Name = "gLbl";
            this.gLbl.Size = new System.Drawing.Size(0, 37);
            this.gLbl.TabIndex = 58;
            // 
            // gLblFecha
            // 
            this.gLblFecha.AutoSize = true;
            this.gLblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblFecha.ForeColor = System.Drawing.Color.Black;
            this.gLblFecha.Location = new System.Drawing.Point(796, 399);
            this.gLblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gLblFecha.Name = "gLblFecha";
            this.gLblFecha.Size = new System.Drawing.Size(0, 37);
            this.gLblFecha.TabIndex = 59;
            // 
            // gLblSare
            // 
            this.gLblSare.AutoSize = true;
            this.gLblSare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblSare.ForeColor = System.Drawing.Color.Black;
            this.gLblSare.Location = new System.Drawing.Point(465, 278);
            this.gLblSare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gLblSare.Name = "gLblSare";
            this.gLblSare.Size = new System.Drawing.Size(0, 37);
            this.gLblSare.TabIndex = 60;
            // 
            // frmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1905, 1237);
            this.Controls.Add(this.gLblSare);
            this.Controls.Add(this.gLblFecha);
            this.Controls.Add(this.gLbl);
            this.Controls.Add(this.gBtnGenerarExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.mthCalendar);
            this.Controls.Add(this.dtgvArchivos);
            this.Controls.Add(this.gcmbxRegion);
            this.Controls.Add(this.gbtnAssignPrint);
            this.Controls.Add(this.gcmbxPrint);
            this.Controls.Add(this.gBtnReturnPrint);
            this.Controls.Add(this.gBtnGenerarPdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAsignacion";
            this.Text = "frmAsignacion";
            this.Load += new System.EventHandler(this.frmAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArchivos)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgvArchivos;
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
        private Guna.UI.WinForms.GunaLabel gLbl;
        private Guna.UI.WinForms.GunaLabel gLblFecha;
        private Guna.UI.WinForms.GunaLabel gLblSare;
    }
}