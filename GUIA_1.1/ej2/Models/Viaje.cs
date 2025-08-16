using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ej2.Models
{
    internal class Viaje
    {
        int transportados; public int Transportados { get { return transportados; } }
        int asientos; public int Asientos { get {return asientos; } }
        int hDemora; public int HDemora { get { return hDemora; } }
        int mDemora; public int MDemora { get { return mDemora; } }
        int cantParadas; public int CantParadas { get { return cantParadas; } }
        int hDuracionViaje; public int HDuracionViaje { get { return hDuracionViaje; } }
        int mDuracionViaje; public int MDuracionViaje { get { return mDuracionViaje; } }
        int hInicioViaje;
        int mInicioViaje;
        public Viaje(int asientosUnidad, int hInicio, int mInicio)
        {
            asientos = asientosUnidad;
            transportados = 0;
            hDemora = 0;
            mDemora = 0;
            cantParadas = 0;
            hDuracionViaje = 0;
            mDuracionViaje = 0;
            hInicioViaje = hInicio;
            mInicioViaje = mInicio;
        }
        public void AsciendenYDescienden(int ascienden, int descienden)
        {
            if (asientos > 0 && ascienden <= asientos)
            {
                asientos -= ascienden;
                transportados += ascienden;
            }
            if (descienden <= transportados)
            {
                asientos += descienden;
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
        public void Finalizar(int hLlegada, int mLlegada)
        {
            int mDuracionTotal = (hLlegada * 60 + mLlegada) - (hInicioViaje * 60 + mInicioViaje);
            hDuracionViaje = mDuracionTotal / 60;
            mDuracionViaje = mDuracionTotal % 60;
        }
    }
}
