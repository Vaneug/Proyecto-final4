using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Equipos_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iId_Equipo, _iEstado_Id, _iTorre_Id, _iTeclado_Id, _iRaton_Id, _iOtro_Id, _iDisco_Id,
           _iMemoria_Id, _iMonitor_Id;
        private string _sEstado, _sTipoTorre, _sTipoTeclado, _sTipoRaton, _sTipoOtro, _sTipoDisco, _sMarcaMemoria, _sMarcaMonitor;
        private string _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        #endregion
        #region VARIABLES PUBLICAS
        public int iId_Equipo { get => _iId_Equipo; set => _iId_Equipo = value; }
        public int iEstado_Id { get => _iEstado_Id; set => _iEstado_Id = value; }
        public int iTorre_Id { get => _iTorre_Id; set => _iTorre_Id = value; }
        public int iTeclado_Id { get => _iTeclado_Id; set => _iTeclado_Id = value; }
        public int iRaton_Id { get => _iRaton_Id; set => _iRaton_Id = value; }
        public int iOtro_Id { get => _iOtro_Id; set => _iOtro_Id = value; }
        public int iDisco_Id { get => _iDisco_Id; set => _iDisco_Id = value; }
        public int iMemoria_Id { get => _iMemoria_Id; set => _iMemoria_Id = value; }
        public int iMonitor_Id { get => _iMonitor_Id; set => _iMonitor_Id = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string sEstado { get => _sEstado; set => _sEstado = value; }
        public string sTipoTorre { get => _sTipoTorre; set => _sTipoTorre = value; }
        public string sTipoTeclado { get => _sTipoTeclado; set => _sTipoTeclado = value; }
        public string sTipoRaton { get => _sTipoRaton; set => _sTipoRaton = value; }
        public string sTipoOtro { get => _sTipoOtro; set => _sTipoOtro = value; }
        public string sTipoDisco { get => _sTipoDisco; set => _sTipoDisco = value; }
        public string sMarcaMemoria { get => _sMarcaMemoria; set => _sMarcaMemoria = value; }
        public string sMarcaMonitor { get => _sMarcaMonitor; set => _sMarcaMonitor = value; }
        #endregion

    }
}
