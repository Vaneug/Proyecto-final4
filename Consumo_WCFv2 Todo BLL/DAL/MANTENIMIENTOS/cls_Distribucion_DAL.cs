using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Distribucion_DAL
    {
        #region VARIABLES PRIVADAS 

        private int _iID_Dsitribucion, _iID_Equipo, _iID_Empleado;
        private string _sMsjError, _sNomEmpelado, _sNomTorre, _sNomMonitor,
                      _sNomTeclado, _sNomRaton, _sNomMemoria, _sNomDisco, _sNomOtro;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region VARIABLES PUBLICAS 

        public int iID_Dsitribucion { get => _iID_Dsitribucion; set => _iID_Dsitribucion = value; }
        public int iID_Equipo { get => _iID_Equipo; set => _iID_Equipo = value; }
        public int iID_Empleado { get => _iID_Empleado; set => _iID_Empleado = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sNomEmpelado { get => _sNomEmpelado; set => _sNomEmpelado = value; }
        public string sNomTorre { get => _sNomTorre; set => _sNomTorre = value; }
        public string sNomMonitor { get => _sNomMonitor; set => _sNomMonitor = value; }
        public string sNomTeclado { get => _sNomTeclado; set => _sNomTeclado = value; }
        public string sNomRaton { get => _sNomRaton; set => _sNomRaton = value; }
        public string sNomMemoria { get => _sNomMemoria; set => _sNomMemoria = value; }
        public string sNomDisco { get => _sNomDisco; set => _sNomDisco = value; }
        public string sNomOtro { get => _sNomOtro; set => _sNomOtro = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion

    }
}
