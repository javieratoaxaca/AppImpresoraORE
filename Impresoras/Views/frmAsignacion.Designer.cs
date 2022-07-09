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
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gbtnExaminarCapturaOPD = new Guna.UI.WinForms.GunaButton();
            this.gBtnImportarBDCerm = new Guna.UI.WinForms.GunaButton();
            this.gBtnExcel = new Guna.UI.WinForms.GunaButton();
            this.gLbl = new Guna.UI.WinForms.GunaLabel();
            this.gLblFecha = new Guna.UI.WinForms.GunaLabel();
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
            this.gcmbxPrint.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.gcmbxPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxPrint.FormattingEnabled = true;
            this.gcmbxPrint.Location = new System.Drawing.Point(94, 108);
            this.gcmbxPrint.Name = "gcmbxPrint";
            this.gcmbxPrint.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbxPrint.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxPrint.Radius = 15;
            this.gcmbxPrint.Size = new System.Drawing.Size(406, 32);
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
            this.gcmbxRegion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.gcmbxRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxRegion.FormattingEnabled = true;
            this.gcmbxRegion.Location = new System.Drawing.Point(94, 208);
            this.gcmbxRegion.Name = "gcmbxRegion";
            this.gcmbxRegion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gcmbxRegion.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gcmbxRegion.Radius = 15;
            this.gcmbxRegion.Size = new System.Drawing.Size(406, 32);
            this.gcmbxRegion.TabIndex = 28;
            // 
            // dtgvArchivos
            // 
            this.dtgvArchivos.AllowUserToAddRows = false;
            this.dtgvArchivos.AllowUserToDeleteRows = false;
            this.dtgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArchivos.Location = new System.Drawing.Point(118, 321);
            this.dtgvArchivos.Name = "dtgvArchivos";
            this.dtgvArchivos.ReadOnly = true;
            this.dtgvArchivos.Size = new System.Drawing.Size(683, 190);
            this.dtgvArchivos.TabIndex = 29;
            // 
            // mthCalendar
            // 
            this.mthCalendar.Location = new System.Drawing.Point(527, 104);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 30;
            this.mthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gunaLabel1.Location = new System.Drawing.Point(159, 70);
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
            this.gunaLabel2.Location = new System.Drawing.Point(189, 174);
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
            this.gunaLabel3.Location = new System.Drawing.Point(556, 70);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(123, 25);
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
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gunaButton1.Image = global::Impresoras.Properties.Resources.icons8_xls_export_48px;
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(874, 384);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(239, 71);
            this.gunaButton1.TabIndex = 57;
            this.gunaButton1.Text = "Generar Excel";
            // 
            // gbtnExaminarCapturaOPD
            // 
            this.gbtnExaminarCapturaOPD.AnimationHoverSpeed = 0.07F;
            this.gbtnExaminarCapturaOPD.AnimationSpeed = 0.03F;
            this.gbtnExaminarCapturaOPD.BackColor = System.Drawing.Color.Transparent;
            this.gbtnExaminarCapturaOPD.BaseColor = System.Drawing.Color.White;
            this.gbtnExaminarCapturaOPD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gbtnExaminarCapturaOPD.BorderSize = 2;
            this.gbtnExaminarCapturaOPD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtnExaminarCapturaOPD.FocusedColor = System.Drawing.Color.Empty;
            this.gbtnExaminarCapturaOPD.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnExaminarCapturaOPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnExaminarCapturaOPD.Image = global::Impresoras.Properties.Resources.icons8_task_48px;
            this.gbtnExaminarCapturaOPD.ImageSize = new System.Drawing.Size(40, 40);
            this.gbtnExaminarCapturaOPD.Location = new System.Drawing.Point(874, 104);
            this.gbtnExaminarCapturaOPD.Name = "gbtnExaminarCapturaOPD";
            this.gbtnExaminarCapturaOPD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gbtnExaminarCapturaOPD.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gbtnExaminarCapturaOPD.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtnExaminarCapturaOPD.OnHoverImage = null;
            this.gbtnExaminarCapturaOPD.OnPressedColor = System.Drawing.Color.Black;
            this.gbtnExaminarCapturaOPD.Radius = 10;
            this.gbtnExaminarCapturaOPD.Size = new System.Drawing.Size(239, 72);
            this.gbtnExaminarCapturaOPD.TabIndex = 27;
            this.gbtnExaminarCapturaOPD.Text = "Asignar Impresora";
            // 
            // gBtnImportarBDCerm
            // 
            this.gBtnImportarBDCerm.AnimationHoverSpeed = 0.07F;
            this.gBtnImportarBDCerm.AnimationSpeed = 0.03F;
            this.gBtnImportarBDCerm.BackColor = System.Drawing.Color.Transparent;
            this.gBtnImportarBDCerm.BaseColor = System.Drawing.Color.White;
            this.gBtnImportarBDCerm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnImportarBDCerm.BorderSize = 2;
            this.gBtnImportarBDCerm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnImportarBDCerm.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnImportarBDCerm.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnImportarBDCerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnImportarBDCerm.Image = global::Impresoras.Properties.Resources.icons8_return_book_60px;
            this.gBtnImportarBDCerm.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnImportarBDCerm.Location = new System.Drawing.Point(874, 195);
            this.gBtnImportarBDCerm.Name = "gBtnImportarBDCerm";
            this.gBtnImportarBDCerm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnImportarBDCerm.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnImportarBDCerm.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnImportarBDCerm.OnHoverImage = null;
            this.gBtnImportarBDCerm.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnImportarBDCerm.Radius = 10;
            this.gBtnImportarBDCerm.Size = new System.Drawing.Size(239, 71);
            this.gBtnImportarBDCerm.TabIndex = 25;
            this.gBtnImportarBDCerm.Text = "Devolucion Impresora";
            // 
            // gBtnExcel
            // 
            this.gBtnExcel.AnimationHoverSpeed = 0.07F;
            this.gBtnExcel.AnimationSpeed = 0.03F;
            this.gBtnExcel.BackColor = System.Drawing.Color.Transparent;
            this.gBtnExcel.BaseColor = System.Drawing.Color.White;
            this.gBtnExcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gBtnExcel.BorderSize = 2;
            this.gBtnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnExcel.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnExcel.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnExcel.Image = global::Impresoras.Properties.Resources.icons8_export_pdf_60px;
            this.gBtnExcel.ImageSize = new System.Drawing.Size(40, 40);
            this.gBtnExcel.Location = new System.Drawing.Point(874, 291);
            this.gBtnExcel.Name = "gBtnExcel";
            this.gBtnExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gBtnExcel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gBtnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnExcel.OnHoverImage = null;
            this.gBtnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnExcel.Radius = 10;
            this.gBtnExcel.Size = new System.Drawing.Size(239, 71);
            this.gBtnExcel.TabIndex = 24;
            this.gBtnExcel.Text = "Generar Pdf";
            // 
            // gLbl
            // 
            this.gLbl.AutoSize = true;
            this.gLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gLbl.Location = new System.Drawing.Point(288, 70);
            this.gLbl.Name = "gLbl";
            this.gLbl.Size = new System.Drawing.Size(0, 25);
            this.gLbl.TabIndex = 58;
            // 
            // gLblFecha
            // 
            this.gLblFecha.AutoSize = true;
            this.gLblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.gLblFecha.Location = new System.Drawing.Point(751, 116);
            this.gLblFecha.Name = "gLblFecha";
            this.gLblFecha.Size = new System.Drawing.Size(0, 25);
            this.gLblFecha.TabIndex = 59;
            // 
            // frmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1270, 804);
            this.Controls.Add(this.gLblFecha);
            this.Controls.Add(this.gLbl);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.mthCalendar);
            this.Controls.Add(this.dtgvArchivos);
            this.Controls.Add(this.gcmbxRegion);
            this.Controls.Add(this.gbtnExaminarCapturaOPD);
            this.Controls.Add(this.gcmbxPrint);
            this.Controls.Add(this.gBtnImportarBDCerm);
            this.Controls.Add(this.gBtnExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Guna.UI.WinForms.GunaButton gBtnImportarBDCerm;
        private Guna.UI.WinForms.GunaButton gBtnExcel;
        private Guna.UI.WinForms.GunaButton gbtnExaminarCapturaOPD;
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
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gLbl;
        private Guna.UI.WinForms.GunaLabel gLblFecha;
    }
}