using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Ado_Net
{
    internal class Jugador
    {
        private string Nombre; 
        private string Ranking;
        private int Edadd;
        private int CantGS;
        private string PaisDeOrigen; 
        
        public void setNombre(string n)
        {
            Nombre = n; 
        }
        public string getNombre()
        {
            return Nombre; 
        }
        public void setRanking(string r)
        {
            Ranking = r;   
        }
        public string getRanking()
        {
            return Ranking; 
        }
        public int Edad { get; set; }
        public void setCantGS(int a)
        {
            CantGS = a;
        }
        public int getCantGS()
        {
            return CantGS; 
        }
        public void setPais(string pais)
        {
            PaisDeOrigen = pais; 
        }
        public string getPais()
        {
            return PaisDeOrigen;
        }
    }
}
