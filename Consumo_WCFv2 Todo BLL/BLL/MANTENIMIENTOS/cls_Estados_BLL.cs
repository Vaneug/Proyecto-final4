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
    public class cls_Estados_BLL
    {
        public void Actualizar_Estado(ref cls_Estados_DAL Obj_Estados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Estados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Estados_DAL.dtParametros);

            Obj_Estados_DAL.dtParametros.Rows.Add("@id_Estado", "1", Obj_Estados_DAL.iId_Estado);
            Obj_Estados_DAL.dtParametros.Rows.Add("@tipo_Estado", "7", Obj_Estados_DAL.iId_Estado);
            Obj_Estados_DAL.dtParametros.Rows.Add("@id_Equipo", "1", Obj_Estados_DAL.iId_Equipo);

            Obj_Estados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ACTUALIZAR_ESTADO"],
                "NORMAL", Obj_Estados_DAL.dtParametros);
        }

        public void Borrar_Estado(ref cls_Estados_DAL Obj_Estados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Estados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Estados_DAL.dtParametros);

            Obj_Estados_DAL.dtParametros.Rows.Add("@id_Estado", "1", Obj_Estados_DAL.iId_Estado);

            Obj_Estados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["BORRAR_ESTADO"],
                "NORMAL", Obj_Estados_DAL.dtParametros);
        }

        public void List_Filt_Estado(ref cls_Estados_DAL Obj_Estados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Estados_DAL.iId_Estado == 0)
            {
                Obj_Estados_DAL.dtParametros = null;
                Obj_Estados_DAL.dtDatos = Obj_WCF.ListarFiltrar("estados", ConfigurationManager.AppSettings["LISTAR_ESTADO"], null);
            }
            else
            {
                Obj_Estados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Estados_DAL.dtParametros);

                Obj_Estados_DAL.dtParametros.Rows.Add("@filtro", "1", Obj_Estados_DAL.iId_Estado);

                Obj_Estados_DAL.dtDatos = Obj_WCF.ListarFiltrar("estados", ConfigurationManager.AppSettings["FILTRAR_ESTADO"],
                    Obj_Estados_DAL.dtParametros);
            }
        }

        public void Insertar_Estado(ref cls_Estados_DAL Obj_Estados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Estados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Estados_DAL.dtParametros);

            Obj_Estados_DAL.dtParametros.Rows.Add("@id_Estado", "1", Obj_Estados_DAL.iId_Estado);
            Obj_Estados_DAL.dtParametros.Rows.Add("@tipo_Estado", "7", Obj_Estados_DAL.iId_Estado);
            Obj_Estados_DAL.dtParametros.Rows.Add("@id_Equipo", "1", Obj_Estados_DAL.iId_Equipo);


            Obj_Estados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_ESTADO"],
                "NORMAL", Obj_Estados_DAL.dtParametros);
        }
    }
    
}        

