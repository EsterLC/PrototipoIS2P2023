using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_EF;

namespace Capa_Vista_EF
{
    public partial class Tipo_Puesto : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        CsControlador cn = new CsControlador();

        public Tipo_Puesto()
        {
            InitializeComponent();

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { txtID, txtnombre, txtsalario};
            TextBox[] Idtextbox = { txtID, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tipo_puesto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
