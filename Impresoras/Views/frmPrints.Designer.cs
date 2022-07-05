namespace Impresoras.Views
{
    partial class frmPrint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsnDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gTxtBuscarPrint = new Guna.UI.WinForms.GunaTextBox();
            this.gcmbRegion = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dtgvPrints = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrints)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMsnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 47);
            this.panel1.TabIndex = 3;
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
            this.lblMsnDashboard.Size = new System.Drawing.Size(200, 39);
            this.lblMsnDashboard.TabIndex = 1;
            this.lblMsnDashboard.Text = "Dispositivos";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1491, 818);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1227, 768);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvPrints);
            this.panel3.Controls.Add(this.gunaLabel5);
            this.panel3.Controls.Add(this.gTxtBuscarPrint);
            this.panel3.Controls.Add(this.gcmbRegion);
            this.panel3.Controls.Add(this.gunaLabel2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1214, 754);
            this.panel3.TabIndex = 0;
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
            // gTxtBuscarPrint
            // 
            this.gTxtBuscarPrint.BackColor = System.Drawing.Color.Transparent;
            this.gTxtBuscarPrint.BaseColor = System.Drawing.Color.White;
            this.gTxtBuscarPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(143)))), ((int)(((byte)(84)))));
            this.gTxtBuscarPrint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtBuscarPrint.FocusedBaseColor = System.Drawing.Color.White;
            this.gTxtBuscarPrint.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gTxtBuscarPrint.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscarPrint.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gTxtBuscarPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.gTxtBuscarPrint.Location = new System.Drawing.Point(394, 72);
            this.gTxtBuscarPrint.Name = "gTxtBuscarPrint";
            this.gTxtBuscarPrint.PasswordChar = '\0';
            this.gTxtBuscarPrint.Radius = 15;
            this.gTxtBuscarPrint.SelectedText = "";
            this.gTxtBuscarPrint.Size = new System.Drawing.Size(455, 41);
            this.gTxtBuscarPrint.TabIndex = 31;
            this.gTxtBuscarPrint.TextChanged += new System.EventHandler(this.gTxtBuscarODP_TextChanged);
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
            // dtgvPrints
            // 
            this.dtgvPrints.AllowUserToAddRows = false;
            this.dtgvPrints.AllowUserToDeleteRows = false;
            this.dtgvPrints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrints.Location = new System.Drawing.Point(115, 142);
            this.dtgvPrints.Name = "dtgvPrints";
            this.dtgvPrints.ReadOnly = true;
            this.dtgvPrints.Size = new System.Drawing.Size(1001, 570);
            this.dtgvPrints.TabIndex = 33;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1227, 815);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox gTxtBuscarPrint;
        private Guna.UI.WinForms.GunaComboBox gcmbRegion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataGridView dtgvPrints;
    }
}