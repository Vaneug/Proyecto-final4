using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Ratones_DAL
    {
        #region VARIABLES PRIVADAS
        private int _iID_Raton;
        private string _sTipo_Raton, _sMarca_Raton, _sModelo_Raton, _sMsjError;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region VARIABLES PUBLICAS
        public int iId_Raton { get => _iID_Raton; set => _iID_Raton = value; }
        public string sTipo_Raton { get => _sTipo_Raton; set => _sTipo_Raton = value; }
        public string sMarca_Raton { get => _sMarca_Raton; set => _sMarca_Raton = value; }
        public string sModelo_Raton { get => _sModelo_Raton; set => _sModelo_Raton = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion

    }
}
