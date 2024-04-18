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

namespace Parcial2
{
    public partial class MdiPrincipal : Form
    {
        Controlador cn = new Controlador();
        public MdiPrincipal()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
            Button[] apps = {btn_catMarcas };
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            cn.deshabilitarApps(apps);
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            cn.getAccesoApp(1002, apps[0]);
        }

        private void man_boleta_Click(object sender, EventArgs e)
        {

        }
        private void hideSubMenu()
        {

            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btn_mantMarcas_Click(object sender, EventArgs e)
        {
            MantenimientoMarcas form = new MantenimientoMarcas();
            form.MdiParent = this;
            form.Show();
            hideSubMenu();

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
           
            showSubMenu(panelayuda);
        }
    }
}
