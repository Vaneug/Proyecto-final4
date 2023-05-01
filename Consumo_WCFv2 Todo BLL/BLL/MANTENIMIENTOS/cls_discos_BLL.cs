using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;
using BLL.WCF;
using System.Configuration;

namespace BLL.MANTENIMIENTOS
{
    public class cls_discos_BLL
    {
        public void Actualizar_Discos(ref cls_discos_DAL Obj_discos_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_discos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_discos_DAL.dtParametros);

            Obj_discos_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_discos_DAL.iId_Disco);
            Obj_discos_DAL.dtParametros.Rows.Add("@tipo_Disco", "7", Obj_discos_DAL.sTipo_Disco);
           

            Obj_discos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_DISCO"],
                "NORMAL", Obj_discos_DAL.dtParametros);
        }

        public void Borrar_Discos(ref cls_discos_DAL Obj_discos_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_discos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_discos_DAL.dtParametros);

            Obj_discos_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_discos_DAL.iId_Disco);

            Obj_discos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_DISCO"],
                "NORMAL", Obj_discos_DAL.dtParametros);
        }

        public void List_Filt_Discos(ref cls_discos_DAL Obj_discos_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_discos_DAL.iId_Disco == 0)
            {
                Obj_discos_DAL.dtParametros = null;
                Obj_discos_DAL.dtDatos = Obj_WCF.ListarFiltrar("discos", ConfigurationManager.AppSettings["LISTAR_DISCO"], null);
            }
            else
            {
                Obj_discos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_discos_DAL.dtParametros);

                Obj_discos_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_discos_DAL.iId_Disco);

                Obj_discos_DAL.dtDatos = Obj_WCF.ListarFiltrar("discos", ConfigurationManager.AppSettings["FILTRAR_DISCO"],
                    Obj_discos_DAL.dtParametros);
            }
        }

        public void Insertar_Discos(ref cls_discos_DAL Obj_discos_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();
            Obj_discos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_discos_DAL.dtParametros);
            Obj_discos_DAL.dtParametros.Rows.Add("@id_Disco", "1", Obj_discos_DAL.iId_Disco);
            Obj_discos_DAL.dtParametros.Rows.Add("@tipo_Disco", "7", Obj_discos_DAL.sTipo_Disco);
            Obj_discos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_DISCO"],
                "NORMAL", Obj_discos_DAL.dtParametros);
        }
    }
    
}        

