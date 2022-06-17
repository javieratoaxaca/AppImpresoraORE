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
            this.pnlHeaderCaption = new System.Windows.Forms.Panel();
            this.pctIconForm = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormAction = new System.Windows.Forms.Panel();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.pnlFormBar.SuspendLayout();
            this.pnlHeaderCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIconForm)).BeginInit();
            this.pnlFormAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormBar
            // 
            this.pnlFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.pnlFormBar.Controls.Add(this.pnlFormAction);
            this.pnlFormBar.Controls.Add(this.pnlHeaderCaption);
            this.pnlFormBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBar.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFormBar.Name = "pnlFormBar";
            this.pnlFormBar.Size = new System.Drawing.Size(1600, 58);
            this.pnlFormBar.TabIndex = 3;
            // 
            // pnlHeaderCaption
            // 
            this.pnlHeaderCaption.Controls.Add(this.lblTitle);
            this.pnlHeaderCaption.Controls.Add(this.pctIconForm);
            this.pnlHeaderCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeaderCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderCaption.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHeaderCaption.Name = "pnlHeaderCaption";
            this.pnlHeaderCaption.Size = new System.Drawing.Size(309, 58);
            this.pnlHeaderCaption.TabIndex = 1;
            // 
            // pctIconForm
            // 
            this.pctIconForm.BackgroundImage = global::Impresoras.Properties.Resources.Autodidacta_cuadro;
            this.pctIconForm.Image = global::Impresoras.Properties.Resources.Autodidacta_cuadro;
            this.pctIconForm.Location = new System.Drawing.Point(8, 5);
            this.pctIconForm.Margin = new System.Windows.Forms.Padding(6);
            this.pctIconForm.Name = "pctIconForm";
            this.pctIconForm.Size = new System.Drawing.Size(50, 48);
            this.pctIconForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIconForm.TabIndex = 4;
            this.pctIconForm.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(70, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "App Impresora";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFormAction
            // 
            this.pnlFormAction.Controls.Add(this.iconBtnClose);
            this.pnlFormAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormAction.Location = new System.Drawing.Point(1284, 0);
            this.pnlFormAction.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFormAction.Name = "pnlFormAction";
            this.pnlFormAction.Size = new System.Drawing.Size(316, 58);
            this.pnlFormAction.TabIndex = 0;
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
            this.iconBtnClose.Location = new System.Drawing.Point(246, 0);
            this.iconBtnClose.Margin = new System.Windows.Forms.Padding(6);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Size = new System.Drawing.Size(70, 58);
            this.iconBtnClose.TabIndex = 0;
            this.iconBtnClose.UseMnemonic = false;
            this.iconBtnClose.UseVisualStyleBackColor = true;
            // 
            // vwPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pnlFormBar);
            this.Name = "vwPrincipal";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnlFormBar.ResumeLayout(false);
            this.pnlHeaderCaption.ResumeLayout(false);
            this.pnlHeaderCaption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIconForm)).EndInit();
            this.pnlFormAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBar;
        private System.Windows.Forms.Panel pnlFormAction;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private System.Windows.Forms.Panel pnlHeaderCaption;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pctIconForm;
    }
}