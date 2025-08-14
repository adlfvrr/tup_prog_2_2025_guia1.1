using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2.Models
{
    internal class Colectivo
    {
        int transportados;
        int asientos;
        int hDemora;
        int mDemora;
        int cantParadas;
        int hDuracionViaje;
        int mDuracionViaje;
        public Colectivo(int asientosUnidad)
        {
            asientos = asientosUnidad;
            transportados = 0;
            hDemora = 0;
            mDemora = 0;
            cantParadas = 0;
            hDuracionViaje = 0;
            mDuracionViaje = 0;
        }
        public void AsciendenYDescienden(int ascienden, int descienden)
        {
            if(asientos > 0 && ascienden <= asientos)
            {
                asientos -= ascienden;
                transportados += ascienden;
            } 
            if(descienden <= transportados)
            {
                asientos += descienden;
                transportados -= descienden;
            }
        }
        public void RealizarParada(int hLLegadaParada, int mLLegadaParada, int hSalidaParada, int mSalidaParada, int ascienden, int descienden)
        {
            cantParadas++;
            AsciendenYDescienden(ascienden, descienden);
            int mDemoraTotal = (hSalidaParada * 60 + mSalidaParada) - (hLLegadaParada * 60 + mLLegadaParada);
            hDemora += mDemoraTotal / 60;
            mDemora += mDemoraTotal % 60;
        }
        
    }
}
