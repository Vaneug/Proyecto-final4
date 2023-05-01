using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.WCF;
using DAL.MANTENIMIENTOS;


namespace BLL.MANTENIMIENTOS
{
    public class cls_Empleados_BLL
    {
        public void Actualizar_Empleado(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);

            Obj_Empleados_DAL.dtParametros.Rows.Add("@id_usuario", "1", Obj_Empleados_DAL.iID_Empelado);
            Obj_Empleados_DAL.dtParametros.Rows.Add("@nombre", "7", Obj_Empleados_DAL.sNombre);
            Obj_Empleados_DAL.dtParametros.Rows.Add("@telefono", "7", Obj_Empleados_DAL.sTelefono);
            Obj_Empleados_DAL.dtParametros.Rows.Add("@email", "7", Obj_Empleados_DAL.sEmail);
           

            Obj_Empleados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_EMPLEADO"],
                "NORMAL", Obj_Empleados_DAL.dtParametros);
        }

        public void Borrar_Empleado(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);

            Obj_Empleados_DAL.dtParametros.Rows.Add("@id_usuario", "1", Obj_Empleados_DAL.iID_Empelado);

            Obj_Empleados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_EMPLEADO"],
                "NORMAL", Obj_Empleados_DAL.dtParametros);
        }

        public void List_Filt_Empleado(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Empleados_DAL.iID_Empelado == 0)
            {
                Obj_Empleados_DAL.dtParametros = null;
                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("empleado", ConfigurationManager.AppSettings["LISTAR_EMPLEADO"], null);
            }
            else
            {
                Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);

                Obj_Empleados_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Empleados_DAL.iID_Empelado);

                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("empleado", ConfigurationManager.AppSettings["FILTRAR_EMPLEADO"],
                    Obj_Empleados_DAL.dtParametros);
            }
        }

        public void Insertar_Usuario(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);

            Obj_Empleados_DAL.dtParametros.Rows.Add("@id_usuario", "1", Obj_Empleados_DAL.iID_Empelado);
            Obj_Empleados_DAL.dtParametros.Rows.Add("@nombre", "7", Obj_Empleados_DAL.sNombre);
            Obj_Empleados_DAL.dtParametros.Rows.Add("@telefono", "7", Obj_Empleados_DAL.sTelefono);
            Obj_Empleados_DAL.dtParametros.Rows.Add("@email", "7", Obj_Empleados_DAL.sEmail);


            Obj_Empleados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_EMPLEADO"],
                "NORMAL", Obj_Empleados_DAL.dtParametros);
        }
    }
}

