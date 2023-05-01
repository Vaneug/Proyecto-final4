using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.MANTENIMIENTOS;
using BLL.MANTENIMIENTOS;
using System.Data.SqlClient;
using System.Data;

namespace PL
{

    public partial class _Default : Page
    {
        #region VARIABLES GLOBALES DAL

        cls_discos_DAL Obj_discos_DAL = new cls_discos_DAL();
        cls_Equipos_DAL Obj_equipos_DAL = new cls_Equipos_DAL();
        cls_Estados_DAL Obj_estados_DAL = new cls_Estados_DAL();
        cls_Memorias_DAL Obj_memorias_DAL = new cls_Memorias_DAL();
        cls_Monitores_DAL Obj_monitores_DAL = new cls_Monitores_DAL();
        cls_Otros_DAL Obj_otros_DAL = new cls_Otros_DAL();
        cls_Ratones_DAL Obj_ratones_DAL = new cls_Ratones_DAL();
        cls_Teclados_DAL Obj_teclados_DAL = new cls_Teclados_DAL();
        cls_Torres_DAL Obj_torres_DAL = new cls_Torres_DAL();
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();
        #endregion

        #region VARIABLES GLOBALES BLL

        cls_discos_BLL Obj_discos_BLL = new cls_discos_BLL();
        cls_Equipos_BLL Obj_equipos_BLL = new cls_Equipos_BLL();
        cls_Estados_BLL Obj_estados_BLL = new cls_Estados_BLL();
        cls_Memorias_BLL Obj_memorias_BLL = new cls_Memorias_BLL();
        cls_Monitores_BLL Obj_monitores_BLL = new cls_Monitores_BLL();
        cls_Otros_BLL Obj_otros_BLL = new cls_Otros_BLL();
        cls_Ratones_BLL Obj_ratones_BLL = new cls_Ratones_BLL();
        cls_Teclados_BLL Obj_teclados_BLL = new cls_Teclados_BLL();
        cls_Torres_BLL Obj_torres_BLL = new cls_Torres_BLL();
        cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
        #endregion
        
        int resul_switch = 0;
        public void btn_filtrar_Click(object sender, EventArgs e)
        {
            int filtro_num = 0;
            filtro_num = Convert.ToInt32(txt_filtro.Text);
            if (filtro_num > 0 && filtro_num <= 7)
            {
                
                switch (filtro_num)
                {
                    case 1:
                        //se inserta código para jalar la tabla de Monitores
                        resul_switch = 1;
                        break;
                    case 2:
                        //se inserta código para jalar la tabla de Teclados
                        resul_switch = 2;
                        break;
                    case 3:
                        //se inserta código para jalar la tabla de Memorias
                        resul_switch = 3;
                        break;
                    case 4:
                        //se inserta código para jalar la tabla de Mouse
                        resul_switch = 4;
                        break;
                    case 5:
                        //se inserta código para jalar la tabla de Torres
                        resul_switch = 5;
                        break;
                    case 6:
                        //se inserta código para jalar la tabla de Discos
                        resul_switch = 6;
                        break;
                    case 7:
                        //se inserta código para jalar la tabla de Otros
                        resul_switch = 7;
                        break;
                }
            }
            else
            {
                /*
                string Mensaje_Error = "El numero ingresado no coincide con ninguno de los mostrados en la lista anterior.";
                string Titulo_Error = "Error!";
                MessageBox.Show(Mensaje_Error, Titulo_Error);
                */
                txt_filtro.ForeColor = System.Drawing.Color.Red;
                txt_filtro.Text = "El numero ingresado no coincide.";
            }
        }
        protected void CargarDatos()
        {
            switch (resul_switch)
            {
                case 1:
                    Obj_monitores_DAL.sMarca_Monitor = txt_filtro.Text.Trim();

                    Obj_monitores_BLL.List_Filt_Monitor(ref Obj_monitores_DAL);

                    GV_Tabla.DataSource = null;
                    GV_Tabla.DataSource = Obj_monitores_DAL.dtDatos;
                    GV_Tabla.DataBind();
                    break;
                case 2:
                    Obj_teclados_DAL.sMarca_Teclado = txt_filtro.Text.Trim();

                    Obj_teclados_BLL.List_Filt_Teclado(ref Obj_teclados_DAL);

                    GV_Tabla.DataSource = null;
                    GV_Tabla.DataSource = Obj_teclados_DAL.dtDatos;
                    GV_Tabla.DataBind();
                    break;
                case 3:
                    //se inserta código para jalar la tabla de Memorias
                    Obj_memorias_DAL.sTipo_Memoria = txt_filtro.Text.Trim();

                    Obj_memorias_BLL.List_Filt_Memoria(ref Obj_memorias_DAL);

                    GV_Tabla.DataSource = null;
                    GV_Tabla.DataSource = Obj_memorias_DAL.dtDatos;
                    GV_Tabla.DataBind();
                    break;
                case 4:
                    //se inserta código para jalar la tabla de Mouse
                    Obj_ratones_DAL.sMarca_Raton = txt_filtro.Text.Trim();

                    Obj_ratones_BLL.List_Filt_Ratones(ref Obj_ratones_DAL);

                    GV_Tabla.DataSource = null;
                    GV_Tabla.DataSource = Obj_ratones_DAL.dtDatos;
                    GV_Tabla.DataBind();
                    break;
                case 5:
                    //se inserta código para jalar la tabla de Torres
                    Obj_torres_DAL.sMarca_Torre = txt_filtro.Text.Trim();

                    Obj_torres_BLL.List_Filt_Torre(ref Obj_torres_DAL);

                    GV_Tabla.DataSource = null;
                    GV_Tabla.DataSource = Obj_torres_DAL.dtDatos;
                    GV_Tabla.DataBind();
                    break;
                case 6:
                    //se inserta código para jalar la tabla de Discos
                    Obj_discos_DAL.sTipo_Disco = txt_filtro.Text.Trim();

                    Obj_discos_BLL.List_Filt_Discos(ref Obj_discos_DAL);

                    GV_Tabla.DataSource = null;
                    GV_Tabla.DataSource = Obj_discos_DAL.dtDatos;
                    GV_Tabla.DataBind();
                    break;
                case 7:
                    //se inserta código para jalar la tabla de otros
                    Obj_otros_DAL.sMarca_Otro = txt_filtro.Text.Trim();

                    Obj_otros_BLL.List_Filt_Otro(ref Obj_otros_DAL);

                    GV_Tabla.DataSource = null;
                    GV_Tabla.DataSource = Obj_otros_DAL.dtDatos;
                    GV_Tabla.DataBind();
                    break;
            }
        }
        protected void CargarCombos()
        {
            switch (resul_switch)
            {
                case 1:
                    //se inserta código para jalar la tabla de Monitores
                    Obj_monitores_DAL.sMarca_Monitor = "";

                    Obj_monitores_BLL.List_Filt_Monitor(ref Obj_monitores_DAL);

                    Obj_monitores_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN MONITOR ---");

                    
                    ddl_opciones.DataSource = null;
                    ddl_opciones.DataTextField = "NOMBRE MONITOR";
                    ddl_opciones.DataValueField = "ID MONITOR"; //CORREGIR NOMBRE A COMO ESTÁ EN LA BASE DE DATOS
                    ddl_opciones.DataSource = Obj_monitores_DAL.dtDatos;
                    ddl_opciones.DataBind();
                    break;
                case 2:
                    //se inserta código para jalar la tabla de Teclados
                    Obj_teclados_DAL.sMarca_Teclado = "";

                    Obj_teclados_BLL.List_Filt_Teclado(ref Obj_teclados_DAL);

                    Obj_teclados_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN TECLADO ---");

                    ddl_opciones.DataSource = null;
                    ddl_opciones.DataTextField = "NOMBRE TECLADO";
                    ddl_opciones.DataValueField = "ID TECLADO";
                    ddl_opciones.DataSource = Obj_teclados_DAL.dtDatos;
                    ddl_opciones.DataBind();
                    break;
                case 3:
                    //se inserta código para jalar la tabla de Memorias
                    Obj_memorias_DAL.sTipo_Memoria = "";

                    Obj_memorias_BLL.List_Filt_Memoria(ref Obj_memorias_DAL);

                    Obj_memorias_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA MEMORIA ---");

                    ddl_opciones.DataSource = null;
                    ddl_opciones.DataTextField = "NOMBRE MEMORIA";
                    ddl_opciones.DataValueField = "ID MEMORIA";//CORREGIR NOMBRE A COMO ESTÁ EN LA BASE DE DATOS
                    ddl_opciones.DataSource = Obj_memorias_DAL.dtDatos;
                    ddl_opciones.DataBind();
                    break;
                case 4:
                    //se inserta código para jalar la tabla de Mouse
                    Obj_ratones_DAL.sTipo_Raton = "";

                    Obj_ratones_BLL.List_Filt_Ratones(ref Obj_ratones_DAL);

                    Obj_ratones_DAL.dtDatos.Rows.Add("0", "--- SELECCIONES UN MOUSE ---");

                    ddl_opciones.DataSource = null;
                    ddl_opciones.DataTextField = "NOMBRE MOUSE";
                    ddl_opciones.DataValueField = "ID MOUSE";//CORREGIR NOMBRE A COMO ESTÁ EN LA BASE DE DATOS
                    ddl_opciones.DataSource = Obj_ratones_DAL.dtDatos;
                    ddl_opciones.DataBind();
                    break;
                case 5:
                    //se inserta código para jalar la tabla de Torres
                    Obj_torres_DAL.sMarca_Torre = "";

                    Obj_torres_BLL.List_Filt_Torre(ref Obj_torres_DAL);

                    Obj_torres_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA TORRE ---");

                    ddl_opciones.DataSource = null;
                    ddl_opciones.DataTextField = "NOMBRE TORRE";
                    ddl_opciones.DataValueField = "ID TORRE";//CORREGIR NOMBRE A COMO ESTÁ EN LA BASE DE DATOS
                    ddl_opciones.DataSource = Obj_torres_DAL.dtDatos;
                    ddl_opciones.DataBind();
                    break;
                case 6:
                    //se inserta código para jalar la tabla de Discos
                    Obj_discos_DAL.sTipo_Disco = "";

                    Obj_discos_BLL.List_Filt_Discos(ref Obj_discos_DAL);

                    Obj_discos_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN DISCO ---");

                    ddl_opciones.DataSource = null;
                    ddl_opciones.DataTextField = "NOMBRE DISCO";
                    ddl_opciones.DataValueField = "ID DISCO";//CORREGIR NOMBRE A COMO ESTÁ EN LA BASE DE DATOS
                    ddl_opciones.DataSource = Obj_discos_DAL.dtDatos;
                    ddl_opciones.DataBind();
                    break;
                case 7:
                    //se inserta código para jalar la tabla de Otros
                    Obj_otros_DAL.sModelo_Otro = "";

                    Obj_otros_BLL.List_Filt_Otro(ref Obj_otros_DAL);

                    Obj_otros_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE OTRO ---");

                    ddl_opciones.DataSource = null;
                    ddl_opciones.DataTextField = "NOMBRE OTRO";
                    ddl_opciones.DataValueField = "ID OTRO";//CORREGIR NOMBRE A COMO ESTÁ EN LA BASE DE DATOS
                    ddl_opciones.DataSource = Obj_otros_DAL.dtDatos;
                    ddl_opciones.DataBind();
                    break;
            }
        }
        protected void btn_Borrar_Click(object sender, EventArgs e)
        {
            switch (resul_switch)
            {
                case 1:
                    //se inserta código para jalar la tabla de Monitores
                    Obj_monitores_DAL.sMarca_Monitor = txt_IdTeclado.Text.Trim();

                    Obj_monitores_BLL.Borrar_Monitor(ref Obj_monitores_DAL);

                    txt_filtro.Text = string.Empty;
                    CargarDatos();
                    break;
                case 2:
                    //se inserta código para jalar la tabla de Teclados
                    Obj_teclados_DAL.sMarca_Teclado = txt_IdTeclado.Text.Trim();

                    Obj_teclados_BLL.Borrar_Teclado(ref Obj_teclados_DAL);

                    txt_filtro.Text = string.Empty;
                    CargarDatos();
                    break;
                case 3:
                    //se inserta código para jalar la tabla de Memorias
                    Obj_memorias_DAL.sTipo_Memoria = txt_IdTeclado.Text.Trim();

                    Obj_memorias_BLL.Borrar_Memoria(ref Obj_memorias_DAL);

                    txt_filtro.Text = string.Empty;
                    CargarDatos();
                    break;
                case 4:
                    //se inserta código para jalar la tabla de Mouse
                    Obj_ratones_DAL.sMarca_Raton = txt_IdTeclado.Text.Trim();

                    Obj_ratones_BLL.Borrar_Raton(ref Obj_ratones_DAL);

                    txt_filtro.Text = string.Empty;
                    CargarDatos();
                    break;
                case 5:
                    //se inserta código para jalar la tabla de Torres
                    Obj_torres_DAL.sMarca_Torre = txt_IdTeclado.Text.Trim();

                    Obj_torres_BLL.Borrar_Torre(ref Obj_torres_DAL);

                    txt_filtro.Text = string.Empty;
                    CargarDatos();
                    break;
                case 6:
                    //se inserta código para jalar la tabla de Discos
                    Obj_discos_DAL.sTipo_Disco = txt_IdTeclado.Text.Trim();

                    Obj_discos_BLL.Borrar_Discos(ref Obj_discos_DAL);

                    txt_filtro.Text = string.Empty;
                    CargarDatos();
                    break;
                case 7:
                    //se inserta código para jalar la tabla de Otros
                    Obj_otros_DAL.sMarca_Otro = txt_IdTeclado.Text.Trim();

                    Obj_otros_BLL.Borrar_Otro(ref Obj_otros_DAL);

                    txt_filtro.Text = string.Empty;
                    CargarDatos();
                    break;
            }
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {
            switch (resul_switch)
            {
                case 1:
                    //se inserta código para jalar la tabla de Monitores
                    Obj_monitores_DAL.sMarca_Monitor = txt_IdTeclado.Text.Trim();
                    Obj_monitores_DAL.sModelo_Monitor = txt_IdTeclado.Text.Trim();
                    Obj_monitores_DAL.iId_Monitor = Convert.ToInt32(ddl_opciones.SelectedValue.ToString().Trim());

                    Obj_monitores_BLL.Insertar_Monitor(ref Obj_monitores_DAL);

                    txt_filtro.Text = string.Empty;
                    txt_MarcaTeclado.Text = string.Empty;
                    CargarDatos();
                    break;
                case 2:
                    //se inserta código para jalar la tabla de Teclados
                    Obj_teclados_DAL.sMarca_Teclado = txt_IdTeclado.Text.Trim();
                    Obj_teclados_DAL.sModelo_Teclado = txt_IdTeclado.Text.Trim();
                    Obj_teclados_DAL.iId_Teclado = Convert.ToInt32(ddl_opciones.SelectedValue.ToString().Trim());

                    Obj_teclados_BLL.Insertar_Teclados(ref Obj_teclados_DAL);

                    txt_filtro.Text = string.Empty;
                    txt_MarcaTeclado.Text = string.Empty;
                    CargarDatos();
                    break;
                case 3:
                    //se inserta código para jalar la tabla de memorias
                    Obj_memorias_DAL.sTipo_Memoria = txt_IdTeclado.Text.Trim();
                    Obj_memorias_DAL.iId_Memoria = Convert.ToInt32(ddl_opciones.SelectedValue.ToString().Trim());

                    Obj_memorias_BLL.Insertar_Memoria(ref Obj_memorias_DAL);

                    txt_filtro.Text = string.Empty;
                    txt_MarcaTeclado.Text = string.Empty;
                    CargarDatos();
                    break;
                case 4:
                    //se inserta código para jalar la tabla de Mouse
                    Obj_ratones_DAL.sTipo_Raton = txt_IdTeclado.Text.Trim();
                    Obj_ratones_DAL.sMarca_Raton = txt_IdTeclado.Text.Trim();
                    Obj_ratones_DAL.sModelo_Raton = txt_IdTeclado.Text.Trim();
                    Obj_ratones_DAL.iId_Raton = Convert.ToInt32(ddl_opciones.SelectedValue.ToString().Trim());

                    Obj_ratones_BLL.Insertar_Raton(ref Obj_ratones_DAL);

                    txt_filtro.Text = string.Empty;
                    txt_MarcaTeclado.Text = string.Empty;
                    CargarDatos();
                    break;
                case 5:
                    //se inserta código para jalar la tabla de torres
                    Obj_torres_DAL.sMarca_Torre = txt_IdTeclado.Text.Trim();
                    Obj_torres_DAL.sModelo_Torre = txt_ModeloTeclado.Text.Trim();
                    Obj_torres_DAL.iId_Torre = Convert.ToInt32(ddl_opciones.SelectedValue.ToString().Trim());

                    Obj_torres_BLL.Insertar_Torre(ref Obj_torres_DAL);

                    txt_filtro.Text = string.Empty;
                    txt_MarcaTeclado.Text = string.Empty;
                    CargarDatos();
                    break;
                case 6:
                    //se inserta código para jalar la tabla de discos
                    Obj_discos_DAL.sTipo_Disco = txt_IdTeclado.Text.Trim();
                    Obj_discos_DAL.iId_Disco = Convert.ToInt32(ddl_opciones.SelectedValue.ToString().Trim());

                    Obj_discos_BLL.Insertar_Discos(ref Obj_discos_DAL);

                    txt_filtro.Text = string.Empty;
                    txt_MarcaTeclado.Text = string.Empty;
                    CargarDatos();
                    break;
                case 7:
                    //se inserta código para jalar la tabla de Otros
                    Obj_otros_DAL.sMarca_Otro = txt_IdTeclado.Text.Trim();
                    Obj_otros_DAL.sModelo_Otro = txt_IdTeclado.Text.Trim();
                    Obj_otros_DAL.iId_Otro = Convert.ToInt32(ddl_opciones.SelectedValue.ToString().Trim());

                    Obj_otros_BLL.Insertar_Otro(ref Obj_otros_DAL);

                    txt_filtro.Text = string.Empty;
                    txt_MarcaTeclado.Text = string.Empty;
                    CargarDatos();
                    break;
            }
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        protected void GridView_Click(object sender, EventArgs e)
        {
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        protected void txt_Eliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}