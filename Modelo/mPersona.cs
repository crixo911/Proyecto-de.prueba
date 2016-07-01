using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class mPersona
    {
        int intCodigo;

        String strNombres;
        String strApellidos;
        String strCedula;
        String strSexo;


        public int getCodigo()
        {
            return intCodigo;
        }

        public void setCodigo(int intCod)
        {
            this.intCodigo = intCod;
        }

        public String getNombres()
        {
            return strNombres;
        }

        public void setNombres(String strNom)
        {
            this.strNombres = strNom;
        }

        public String getApellidos()
        {
            return strApellidos;
        }

        public void setApellidos(String strApe)
        {
            this.strApellidos = strApe;
        }

        public String getCedula()
        {
            return strCedula;
        }

        public void setCedula(String strCed)
        {
            this.strCedula = strCed;
        }

        public String getSexo()
        {
            return strSexo;
        }

        public void setSexo(String strSex)
        {
            this.strSexo = strSex;
        }
    }
}
