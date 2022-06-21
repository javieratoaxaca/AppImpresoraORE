namespace Impresoras.Views
{
    partial class vwPrincipal
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
            this.pnlFormBar = new System.Windows.Forms.Panel();
            this.iconBtnBar = new FontAwesome.Sharp.IconButton();
            this.pnlFormAction = new System.Windows.Forms.Panel();
            this.iconBtnMinus = new FontAwesome.Sharp.IconButton();
            this.iconBtnPlus = new FontAwesome.Sharp.IconButton();
            this.iconBtnNormal = new FontAwesome.Sharp.IconButton();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.pnlHeaderCaption = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pctIconForm = new System.Windows.Forms.PictureBox();
            this.pnlSlideMenu = new System.Windows.Forms.Panel();
            this.pnlSlideMenuImg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconBtnDashboard = new FontAwesome.Sharp.IconButton();
            this.iconBtnPrint = new FontAwesome.Sharp.IconButton();
            this.pnlSubMenuCatalogo = new System.Windows.Forms.Panel();
            this.iconBtnAlta = new FontAwesome.Sharp.IconButton();
            this.iconBtnAsignacion = new FontAwesome.Sharp.IconButton();
            this.iconBtnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.pnlFormBar.SuspendLayout();
            this.pnlFormAction.SuspendLayout();
            this.pnlHeaderCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIconForm)).BeginInit();
            this.pnlSlideMenu.SuspendLayout();
            this.pnlSlideMenuImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSubMenuCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormBar
            // 
            this.pnlFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.pnlFormBar.Controls.Add(this.iconBtnBar);
            this.pnlFormBar.Controls.Add(this.pnlFormAction);
            this.pnlFormBar.Controls.Add(this.pnlHeaderCaption);
            this.pnlFormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBar.Name = "pnlFormBar";
            this.pnlFormBar.Size = new System.Drawing.Size(1208, 30);
            this.pnlFormBar.TabIndex = 3;
            this.pnlFormBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindows_MouseDown);
            // 
            // iconBtnBar
            // 
            this.iconBtnBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBtnBar.FlatAppearance.BorderSize = 0;
            this.iconBtnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnBar.ForeColor = System.Drawing.Color.White;
            this.iconBtnBar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconBtnBar.IconColor = System.Drawing.Color.White;
            this.iconBtnBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnBar.IconSize = 25;
            this.iconBtnBar.Location = new System.Drawing.Point(170, 0);
            this.iconBtnBar.Name = "iconBtnBar";
            this.iconBtnBar.Size = new System.Drawing.Size(37, 30);
            this.iconBtnBar.TabIndex = 4;
            this.iconBtnBar.UseVisualStyleBackColor = true;
            this.iconBtnBar.Click += new System.EventHandler(this.iconBtnBar_Click);
            // 
            // pnlFormAction
            // 
            this.pnlFormAction.Controls.Add(this.iconBtnMinus);
            this.pnlFormAction.Controls.Add(this.iconBtnPlus);
            this.pnlFormAction.Controls.Add(this.iconBtnNormal);
            this.pnlFormAction.Controls.Add(this.iconBtnClose);
            this.pnlFormAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormAction.Location = new System.Drawing.Point(1058, 0);
            this.pnlFormAction.Name = "pnlFormAction";
            this.pnlFormAction.Size = new System.Drawing.Size(150, 30);
            this.pnlFormAction.TabIndex = 0;
            // 
            // iconBtnMinus
            // 
            this.iconBtnMinus.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnMinus.FlatAppearance.BorderSize = 0;
            this.iconBtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconBtnMinus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(194)))), ((int)(((byte)(59)))));
            this.iconBtnMinus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnMinus.IconSize = 25;
            this.iconBtnMinus.Location = new System.Drawing.Point(3, 0);
            this.iconBtnMinus.Name = "iconBtnMinus";
            this.iconBtnMinus.Size = new System.Drawing.Size(38, 30);
            this.iconBtnMinus.TabIndex = 1;
            this.iconBtnMinus.UseMnemonic = false;
            this.iconBtnMinus.UseVisualStyleBackColor = true;
            this.iconBtnMinus.Click += new System.EventHandler(this.iconBtnMinus_Click);
            // 
            // iconBtnPlus
            // 
            this.iconBtnPlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnPlus.FlatAppearance.BorderSize = 0;
            this.iconBtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconBtnPlus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconBtnPlus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(192)))), ((int)(((byte)(58)))));
            this.iconBtnPlus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnPlus.IconSize = 25;
            this.iconBtnPlus.Location = new System.Drawing.Point(41, 0);
            this.iconBtnPlus.Name = "iconBtnPlus";
            this.iconBtnPlus.Size = new System.Drawing.Size(37, 30);
            this.iconBtnPlus.TabIndex = 2;
            this.iconBtnPlus.UseMnemonic = false;
            this.iconBtnPlus.UseVisualStyleBackColor = true;
            this.iconBtnPlus.Click += new System.EventHandler(this.iconBtnPlus_Click);
            // 
            // iconBtnNormal
            // 
            this.iconBtnNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnNormal.FlatAppearance.BorderSize = 0;
            this.iconBtnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnNormal.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconBtnNormal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(192)))), ((int)(((byte)(58)))));
            this.iconBtnNormal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnNormal.IconSize = 25;
            this.iconBtnNormal.Location = new System.Drawing.Point(78, 0);
            this.iconBtnNormal.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.iconBtnNormal.Name = "iconBtnNormal";
            this.iconBtnNormal.Size = new System.Drawing.Size(37, 30);
            this.iconBtnNormal.TabIndex = 3;
            this.iconBtnNormal.UseMnemonic = false;
            this.iconBtnNormal.UseVisualStyleBackColor = true;
            this.iconBtnNormal.Click += new System.EventHandler(this.iconBtnNormal_Click);
            // 
            // iconBtnClose
            // 
            this.iconBtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnClose.FlatAppearance.BorderSize = 0;
            this.iconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClose.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconBtnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.iconBtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnClose.IconSize = 25;
            this.iconBtnClose.Location = new System.Drawing.Point(115, 0);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Size = new System.Drawing.Size(35, 30);
            this.iconBtnClose.TabIndex = 0;
            this.iconBtnClose.UseMnemonic = false;
            this.iconBtnClose.UseVisualStyleBackColor = true;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // pnlHeaderCaption
            // 
            this.pnlHeaderCaption.Controls.Add(this.lblTitle);
            this.pnlHeaderCaption.Controls.Add(this.pctIconForm);
            this.pnlHeaderCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeaderCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderCaption.Name = "pnlHeaderCaption";
            this.pnlHeaderCaption.Size = new System.Drawing.Size(170, 30);
            this.pnlHeaderCaption.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(35, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "App Impresora";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctIconForm
            // 
            this.pctIconForm.BackgroundImage = global::Impresoras.Properties.Resources.Autodidacta_cuadro;
            this.pctIconForm.Image = global::Impresoras.Properties.Resources.Autodidacta_cuadro;
            this.pctIconForm.Location = new System.Drawing.Point(4, 3);
            this.pctIconForm.Name = "pctIconForm";
            this.pctIconForm.Size = new System.Drawing.Size(25, 25);
            this.pctIconForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIconForm.TabIndex = 4;
            this.pctIconForm.TabStop = false;
            // 
            // pnlSlideMenu
            // 
            this.pnlSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.pnlSlideMenu.Controls.Add(this.iconBtnConfiguracion);
            this.pnlSlideMenu.Controls.Add(this.pnlSubMenuCatalogo);
            this.pnlSlideMenu.Controls.Add(this.iconBtnPrint);
            this.pnlSlideMenu.Controls.Add(this.iconBtnDashboard);
            this.pnlSlideMenu.Controls.Add(this.pnlSlideMenuImg);
            this.pnlSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlideMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlSlideMenu.Name = "pnlSlideMenu";
            this.pnlSlideMenu.Size = new System.Drawing.Size(170, 795);
            this.pnlSlideMenu.TabIndex = 4;
            // 
            // pnlSlideMenuImg
            // 
            this.pnlSlideMenuImg.Controls.Add(this.pictureBox1);
            this.pnlSlideMenuImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSlideMenuImg.Location = new System.Drawing.Point(0, 0);
            this.pnlSlideMenuImg.Name = "pnlSlideMenuImg";
            this.pnlSlideMenuImg.Size = new System.Drawing.Size(170, 134);
            this.pnlSlideMenuImg.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impresoras.Properties.Resources.Perfil;
            this.pictureBox1.Location = new System.Drawing.Point(38, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconBtnDashboard
            // 
            this.iconBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnDashboard.FlatAppearance.BorderSize = 0;
            this.iconBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.iconBtnDashboard.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.iconBtnDashboard.IconColor = System.Drawing.Color.White;
            this.iconBtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDashboard.IconSize = 30;
            this.iconBtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDashboard.Location = new System.Drawing.Point(0, 134);
            this.iconBtnDashboard.Name = "iconBtnDashboard";
            this.iconBtnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconBtnDashboard.Size = new System.Drawing.Size(170, 46);
            this.iconBtnDashboard.TabIndex = 1;
            this.iconBtnDashboard.Text = "           Dashboard";
            this.iconBtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDashboard.UseVisualStyleBackColor = true;
            // 
            // iconBtnPrint
            // 
            this.iconBtnPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnPrint.FlatAppearance.BorderSize = 0;
            this.iconBtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnPrint.ForeColor = System.Drawing.Color.White;
            this.iconBtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconBtnPrint.IconColor = System.Drawing.Color.White;
            this.iconBtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnPrint.IconSize = 30;
            this.iconBtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPrint.Location = new System.Drawing.Point(0, 180);
            this.iconBtnPrint.Name = "iconBtnPrint";
            this.iconBtnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconBtnPrint.Size = new System.Drawing.Size(170, 45);
            this.iconBtnPrint.TabIndex = 2;
            this.iconBtnPrint.Text = "           Impresoras";
            this.iconBtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPrint.UseVisualStyleBackColor = true;
            this.iconBtnPrint.Click += new System.EventHandler(this.iconBtnPrint_Click);
            // 
            // pnlSubMenuCatalogo
            // 
            this.pnlSubMenuCatalogo.BackColor = System.Drawing.Color.DimGray;
            this.pnlSubMenuCatalogo.Controls.Add(this.iconBtnAsignacion);
            this.pnlSubMenuCatalogo.Controls.Add(this.iconBtnAlta);
            this.pnlSubMenuCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuCatalogo.Location = new System.Drawing.Point(0, 225);
            this.pnlSubMenuCatalogo.Name = "pnlSubMenuCatalogo";
            this.pnlSubMenuCatalogo.Size = new System.Drawing.Size(170, 92);
            this.pnlSubMenuCatalogo.TabIndex = 3;
            // 
            // iconBtnAlta
            // 
            this.iconBtnAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnAlta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconBtnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAlta.ForeColor = System.Drawing.Color.White;
            this.iconBtnAlta.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconBtnAlta.IconColor = System.Drawing.Color.White;
            this.iconBtnAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAlta.IconSize = 25;
            this.iconBtnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAlta.Location = new System.Drawing.Point(0, 0);
            this.iconBtnAlta.Name = "iconBtnAlta";
            this.iconBtnAlta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconBtnAlta.Size = new System.Drawing.Size(170, 46);
            this.iconBtnAlta.TabIndex = 2;
            this.iconBtnAlta.Text = "          Alta";
            this.iconBtnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAlta.UseVisualStyleBackColor = true;
            // 
            // iconBtnAsignacion
            // 
            this.iconBtnAsignacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnAsignacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconBtnAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAsignacion.ForeColor = System.Drawing.Color.White;
            this.iconBtnAsignacion.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.iconBtnAsignacion.IconColor = System.Drawing.Color.White;
            this.iconBtnAsignacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAsignacion.IconSize = 25;
            this.iconBtnAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAsignacion.Location = new System.Drawing.Point(0, 46);
            this.iconBtnAsignacion.Name = "iconBtnAsignacion";
            this.iconBtnAsignacion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconBtnAsignacion.Size = new System.Drawing.Size(170, 46);
            this.iconBtnAsignacion.TabIndex = 3;
            this.iconBtnAsignacion.Text = "          Asignación";
            this.iconBtnAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAsignacion.UseVisualStyleBackColor = true;
            // 
            // iconBtnConfiguracion
            // 
            this.iconBtnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.iconBtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.iconBtnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconBtnConfiguracion.IconColor = System.Drawing.Color.White;
            this.iconBtnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnConfiguracion.IconSize = 30;
            this.iconBtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnConfiguracion.Location = new System.Drawing.Point(0, 317);
            this.iconBtnConfiguracion.Name = "iconBtnConfiguracion";
            this.iconBtnConfiguracion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconBtnConfiguracion.Size = new System.Drawing.Size(170, 46);
            this.iconBtnConfiguracion.TabIndex = 4;
            this.iconBtnConfiguracion.Text = "           Configuracion";
            this.iconBtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // vwPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1208, 825);
            this.Controls.Add(this.pnlSlideMenu);
            this.Controls.Add(this.pnlFormBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "vwPrincipal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.vwPrincipal_Load);
            this.pnlFormBar.ResumeLayout(false);
            this.pnlFormAction.ResumeLayout(false);
            this.pnlHeaderCaption.ResumeLayout(false);
            this.pnlHeaderCaption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIconForm)).EndInit();
            this.pnlSlideMenu.ResumeLayout(false);
            this.pnlSlideMenuImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSubMenuCatalogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBar;
        private System.Windows.Forms.Panel pnlFormAction;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private System.Windows.Forms.Panel pnlHeaderCaption;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pctIconForm;
        private FontAwesome.Sharp.IconButton iconBtnPlus;
        private FontAwesome.Sharp.IconButton iconBtnNormal;
        private FontAwesome.Sharp.IconButton iconBtnMinus;
        private FontAwesome.Sharp.IconButton iconBtnBar;
        private System.Windows.Forms.Panel pnlSlideMenu;
        private System.Windows.Forms.Panel pnlSlideMenuImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconBtnConfiguracion;
        private System.Windows.Forms.Panel pnlSubMenuCatalogo;
        private FontAwesome.Sharp.IconButton iconBtnAsignacion;
        private FontAwesome.Sharp.IconButton iconBtnAlta;
        private FontAwesome.Sharp.IconButton iconBtnPrint;
        private FontAwesome.Sharp.IconButton iconBtnDashboard;
    }
}