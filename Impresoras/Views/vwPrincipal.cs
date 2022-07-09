using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impresoras.Config;
using System.Runtime.InteropServices;

namespace Impresoras.Views
{
    public partial class vwPrincipal : Form
    {

        private Form frmActivo;
        DBImpresora cnx = new DBImpresora();
        /// <summary> Seccion para el manejo de los eventos de los botonos de la pantalla
        /// 
        private const int widthSlide = 170;
        private const int widthSlideIcon = 45;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Padding borderNormal = new Padding(2);
        private Padding borderMaximized = new Padding(2, 9, 2, 2);

        /// </summary>
        public vwPrincipal()
        {
            
            InitializeComponent();
            InitializeSetting();
            this.Padding = new Padding(2);
        }
        public void InitializeSetting()
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            HideSubMenus();
        }

        private void HideSubMenus()
        {
            pnlSubMenuCatalogo.Visible = false;
        }
        #region MyRegion

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void iconBtnBar_Click(object sender, EventArgs e)
        {
            if (pnlSlideMenu.Width != widthSlideIcon)
            {
                pnlSlideMenu.Width = widthSlideIcon;
                HideSubMenus();
                pnlSlideMenuImg.Visible = false;
            }
            else
            {
                pnlSlideMenu.Width = widthSlide;
                pnlSlideMenuImg.Visible = true;
            }
        }


        #endregion

        #region Botones 
        //Seccion de los Botonos para el control en Pantalla
        private void iconBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnNormal_Click(object sender, EventArgs e)
        {
            normalAction();
        }
        private void iconBtnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconBtnPlus_Click(object sender, EventArgs e)
        {
            maximizedAction();
        }
        private void MoveWindows_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Acciones de Pantalla
        // metodos para el maximizado de la pantalla a lo igual su metodo de normal
        private void maximizedAction()
        {
            this.WindowState = FormWindowState.Maximized;
            iconBtnNormal.Visible = true;
            iconBtnPlus.Visible = false;
            this.Padding = borderMaximized;
        }
        private void normalAction()
        {
            iconBtnNormal.Visible = false;
            iconBtnPlus.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Padding = borderNormal;
        }

        #endregion

        #region 

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.Padding = borderMaximized;
                }
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.Padding = borderNormal;
                }
                return;
            }
            base.WndProc(ref m);
        }
        #endregion


        private void vwPrincipal_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Conexion Exitosa" + cnx.getConnection());
        }

        private void iconBtnPrint_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuCatalogo);
            activeBtn(iconBtnPrint);
            frmShow(new frmPrint());
        }

        #region Metodo Formularios
        private void frmShow(Form frm)
        {
            activeFrmClose();
            frmActivo = frm;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            
            pnlForm.Controls.Add(frm);
            pnlForm.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void activeFrmClose()
        {
            if (frmActivo != null)
                frmActivo.Close();
        }

        private void activeBtn(Button frmActivo)
        {
            foreach (Control ctrl in pnlSlideMenu.Controls)
                ctrl.ForeColor = Color.White;

            frmActivo.ForeColor = Color.Red;
        }
        #endregion

        private void iconBtnDashboard_Click(object sender, EventArgs e)
        {
            activeBtn(iconBtnDashboard);
            activeFrmClose();
        }

        private void iconBtnAlta_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuCatalogo);
            activeBtn(iconBtnPrint);
            frmShow(new frmPrintUp());
        }

        private void iconBtnAsignacion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuCatalogo);
            activeBtn(iconBtnAsignacion);
            frmShow(new frmAsignacion());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuCatalogo);
            activeBtn(iconBtnRegion);
            frmShow(new frmRegion());
        }
    }
}
