using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Memorias_DAL
    {
        #region VARIABLES PRIVADAS 
        private int _iId_Memoria;
        private string _sTipo_Memoria, _sMsjError;
        private DataTable _dtDatos, _dtParametros;
        #endregion


        #region VARIABLES PUBLICAS 
        public int iId_Memoria { get => _iId_Memoria; set => _iId_Memoria = value; }
        public string sTipo_Memoria { get => _sTipo_Memoria; set => _sTipo_Memoria = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion

    }
}
