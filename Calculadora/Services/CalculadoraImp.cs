using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> historico;

        public CalculadoraImp()
        {
            historico = new List<string>();
        }

        public int Somar(int x, int y)
        {
            int resultado = x + y;
            historico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public int Subtrair(int x, int y)
        {
            int resultado = x - y;
            historico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public int Dividir(int x, int y)
        {
            int resultado = x / y;
            historico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public int Multiplicar(int x, int y)
        {
            int resultado = x * y;
            historico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public List<string> HistoricoDeOperacoes()
        {
            historico.RemoveRange(3, historico.Count() - 3);
            return historico;
        }
    }
}