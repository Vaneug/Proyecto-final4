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
    public class cls_Otros_BLL
    {
        public void Actualizar_Otro(ref cls_Otros_DAL Obj_Otros_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Otros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Otros_DAL.dtParametros);

            Obj_Otros_DAL.dtParametros.Rows.Add("@id_Otro", "1", Obj_Otros_DAL.iId_Otro);
            Obj_Otros_DAL.dtParametros.Rows.Add("@tipo_Otro", "7", Obj_Otros_DAL.sTipo_Otro);
            Obj_Otros_DAL.dtParametros.Rows.Add("@marca_Otro", "7", Obj_Otros_DAL.sMarca_Otro);
            Obj_Otros_DAL.dtParametros.Rows.Add("@modelo_Otro", "7", Obj_Otros_DAL.sModelo_Otro);

            Obj_Otros_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_OTRO"],
                "NORMAL", Obj_Otros_DAL.dtParametros);
        }

        public void Borrar_Otro(ref cls_Otros_DAL Obj_Otros_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Otros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Otros_DAL.dtParametros);

            Obj_Otros_DAL.dtParametros.Rows.Add("@id_Otro", "1", Obj_Otros_DAL.iId_Otro);

            Obj_Otros_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_OTRO"],
                "NORMAL", Obj_Otros_DAL.dtParametros);
        }

        public void List_Filt_Otro(ref cls_Otros_DAL Obj_Otros_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Otros_DAL.iId_Otro == 0)
            {
                Obj_Otros_DAL.dtParametros = null;
                Obj_Otros_DAL.dtDatos = Obj_WCF.ListarFiltrar("otros", ConfigurationManager.AppSettings["LISTAR_OTROS"], null);
            }
            else
            {
                Obj_Otros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Otros_DAL.dtParametros);

                Obj_Otros_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Otros_DAL.iId_Otro);

                Obj_Otros_DAL.dtDatos = Obj_WCF.ListarFiltrar("otros", ConfigurationManager.AppSettings["FILTRAR_OTROS"],
                    Obj_Otros_DAL.dtParametros);
            }
        }

        public void Insertar_Otro(ref cls_Otros_DAL Obj_Otros_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Otros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Otros_DAL.dtParametros);

            Obj_Otros_DAL.dtParametros.Rows.Add("@id_Otro", "1", Obj_Otros_DAL.iId_Otro);
            Obj_Otros_DAL.dtParametros.Rows.Add("@tipo_Otro", "7", Obj_Otros_DAL.sTipo_Otro);
            Obj_Otros_DAL.dtParametros.Rows.Add("@marca_Otro", "7", Obj_Otros_DAL.sMarca_Otro);
            Obj_Otros_DAL.dtParametros.Rows.Add("@modelo_Otro", "7", Obj_Otros_DAL.sModelo_Otro);


            Obj_Otros_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_OTRO"],
                "NORMAL", Obj_Otros_DAL.dtParametros);
        }
    }
    
}        

