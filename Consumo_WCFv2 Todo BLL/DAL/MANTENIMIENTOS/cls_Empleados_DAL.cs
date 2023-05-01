using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.MANTENIMIENTOS
{
    public class cls_Empleados_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iID_Empelado;
        private string _sNombre, _sTelefono, _sEmail, _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region VARIABLES PUBLICAS 

        public int iID_Empelado { get => _iID_Empelado; set => _iID_Empelado = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public string sEmail { get => _sEmail; set => _sEmail = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion
    }
}
