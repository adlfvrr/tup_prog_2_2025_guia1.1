using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Moto
    {
        string marca;
        int modelo;
        double valorFabricacion;
        public string Marca { get { return marca; } }
        public int Modelo { get { return modelo; } }
        public double ValorFabricacion { get { return valorFabricacion; } }
        public Moto(string marcaMoto, int modeloMoto, double valorFabricacionMoto)
        {
            marca = marcaMoto;
            modelo = modeloMoto;
            valorFabricacion = valorFabricacionMoto;
        }
        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            int añosDeUso = añoACalcular - Modelo;
            return ValorFabricacion - (ValorFabricacion * (añosDeUso/ (double)vidaUtil));
        }
        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            int añosDeUso = añoACalcular - Modelo;
            return valorFabricacion * Math.Pow((1 - tasaDepreciacion), añosDeUso);
        }
        public string VerDescripcion()
        {
            return $@"Marca: {Marca}, Modelo: {Modelo}, Valor de Fabricación: ${ValorFabricacion:f2}";
        }
    }
}
