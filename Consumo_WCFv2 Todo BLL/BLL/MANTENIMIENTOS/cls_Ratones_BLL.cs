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
    public class cls_Ratones_BLL
    {
        public void Actualizar_Raton(ref cls_Ratones_DAL Obj_Ratones_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Ratones_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Ratones_DAL.dtParametros);

            Obj_Ratones_DAL.dtParametros.Rows.Add("@id_Raton", "1", Obj_Ratones_DAL.iId_Raton);
            Obj_Ratones_DAL.dtParametros.Rows.Add("@tipo_Raton", "7", Obj_Ratones_DAL.sTipo_Raton);
            Obj_Ratones_DAL.dtParametros.Rows.Add("@marca_Raton", "7", Obj_Ratones_DAL.sMarca_Raton);
            Obj_Ratones_DAL.dtParametros.Rows.Add("@modelo_Raton", "7", Obj_Ratones_DAL.sModelo_Raton);

            Obj_Ratones_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_RATON"],
                "NORMAL", Obj_Ratones_DAL.dtParametros);
        }

        public void Borrar_Raton(ref cls_Ratones_DAL Obj_Ratones_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Ratones_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Ratones_DAL.dtParametros);

            Obj_Ratones_DAL.dtParametros.Rows.Add("@id_Raton", "1", Obj_Ratones_DAL.iId_Raton);

            Obj_Ratones_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_RATON"],
                "NORMAL", Obj_Ratones_DAL.dtParametros);
        }

        public void List_Filt_Ratones(ref cls_Ratones_DAL Obj_Ratones_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Ratones_DAL.iId_Raton == 0)
            {
                Obj_Ratones_DAL.dtParametros = null;
                Obj_Ratones_DAL.dtDatos = Obj_WCF.ListarFiltrar("ratones", ConfigurationManager.AppSettings["LISTAR_RATON"], null);
            }
            else
            {
                Obj_Ratones_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Ratones_DAL.dtParametros);

                Obj_Ratones_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Ratones_DAL.iId_Raton);

                Obj_Ratones_DAL.dtDatos = Obj_WCF.ListarFiltrar("ratones", ConfigurationManager.AppSettings["FILTRAR_RATON"],
                    Obj_Ratones_DAL.dtParametros);
            }
        }

        public void Insertar_Raton(ref cls_Ratones_DAL Obj_Ratones_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Ratones_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Ratones_DAL.dtParametros);

            Obj_Ratones_DAL.dtParametros.Rows.Add("@id_Raton", "1", Obj_Ratones_DAL.iId_Raton);
            Obj_Ratones_DAL.dtParametros.Rows.Add("@tipo_Raton", "7", Obj_Ratones_DAL.sTipo_Raton);
            Obj_Ratones_DAL.dtParametros.Rows.Add("@marca_Raton", "7", Obj_Ratones_DAL.sMarca_Raton);
            Obj_Ratones_DAL.dtParametros.Rows.Add("@modelo_Raton", "7", Obj_Ratones_DAL.sModelo_Raton);


            Obj_Ratones_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_RATON"],
                "NORMAL", Obj_Ratones_DAL.dtParametros);
        }
    }
    
}        

