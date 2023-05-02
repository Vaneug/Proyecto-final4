using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL
{
    public partial class frm_Torres : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES
        cls_Torres_DAL Obj_torres_DAL = new cls_Torres_DAL();
        cls_Torres_BLL Obj_torres_BLL = new cls_Torres_BLL();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()//revisado
        {

            if (txtaFiltProd.Text == string.Empty)
            {
                Obj_torres_DAL.iId_Torre = 0;
            }
            else
            {
                Obj_torres_DAL.iId_Torre = Convert.ToInt32(txtaFiltProd.Text.Trim());

            }

            Obj_torres_BLL.List_Filt_Torre(ref Obj_torres_DAL);

            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = Obj_torres_DAL.dtDatos;
            dgv_Productos.DataBind();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdTorre.Text))
            {
                MessageBox.Show("El campo 'ID_Teclado' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Opcional: detiene el procesamiento adicional del código si se encuentra un error
            }
        
            else
            {
                MessageBox.Show("No tiene torres para poder eliminar.",
                                "alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            Obj_torres_DAL.iId_Torre = Convert.ToInt32(txt_IdTorre.Text.Trim());

            Obj_torres_BLL.Borrar_Torre(ref Obj_torres_DAL);

            txt_IdTorre.Text = string.Empty;
            CargarDatos();
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IdTorre.Text))
            {
                MessageBox.Show("El campo 'ID_Torre' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //
            }
            if (string.IsNullOrEmpty(txt_MarcaTorre.Text))
            {
                MessageBox.Show("El campo 'Marca_Torre' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //
            }
            if (string.IsNullOrEmpty(txt_ModeloTorre.Text))
            {
                MessageBox.Show("El campo 'Modelo_Torre' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //
            }
            Obj_torres_DAL.iId_Torre = Convert.ToInt32(txt_IdTorre.Text.Trim());
            Obj_torres_DAL.sMarca_Torre = txt_MarcaTorre.Text.Trim();
            Obj_torres_DAL.sModelo_Torre = txt_ModeloTorre.Text.Trim();

            Obj_torres_BLL.Insertar_Torre(ref Obj_torres_DAL);

            txt_IdTorre.Text = string.Empty;
            txt_MarcaTorre.Text = string.Empty;
            txt_ModeloTorre.Text = string.Empty;
            CargarDatos();
        }
    }
}