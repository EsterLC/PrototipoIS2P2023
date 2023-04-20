using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_Seguridad
{
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        public Menup()
        {
            InitializeComponent();
           
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }
        public void btnlogout_Click(object sender, EventArgs e)
        {

        }

        public void btlogistica_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
              b.Show();
            cn.setBtitacora("2000", "Ingreso Logistica");*/
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            /*ComprasVista.central_Compra b = new ComprasVista.central_Compra();
            b.Show();
            cn.setBtitacora("3000", "Ingreso Compras");*/
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
           b.Show();
            cn.setBtitacora("5000", "Ingreso Produccion");*/
        }

        private void btnnominas_Click(object sender, EventArgs e)
        {
            /*CapaVistaNomina.MenuPrincipal b = new CapaVistaNomina.MenuPrincipal();
            b.Show();
            cn.setBtitacora("6000", "Ingreso Nominas");*/
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
           
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            /*VistaLogistica.Menu b = new VistaLogistica.Menu();
           b.Show();
            cn.setBtitacora("8000", "Ingreso Contabilidad");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCheques_Click(object sender, EventArgs e)
        {
            /*hideSubMenu();
            Vista_Bancos.Cheque b = new Vista_Bancos.Cheque();
            b.MdiParent = this;
            b.Show();
            cn.setBtitacora("7000", "Ingreso Bancos");*/
        }

        private void btnPartidasCont_Click(object sender, EventArgs e)
        {
        }

        private void Procesos_Click(object sender, EventArgs e)
        {
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnReportesBancarios_Click(object sender, EventArgs e)
        {
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMantenimiento.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login b = new Login();
            cn.setBtitacora("999", "Cerro Sesion");
            b.Show();
            this.Close();
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            Capa_Vista_EF.IngresarNotas b = new Capa_Vista_EF.IngresarNotas();
            b.MdiParent = this;
            b.Show();
            cn.setBtitacora("7000", "Ingresar Notas");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Capa_Vista_EF.Cursos b = new Capa_Vista_EF.Cursos();
            b.MdiParent = this;
            b.Show();
            cn.setBtitacora("7001", "Cursos");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitacora b = new Bitacora();
            b.MdiParent = this;
            b.Show();
            cn.setBtitacora("7002", "Bitacora");
        }
    }
}
