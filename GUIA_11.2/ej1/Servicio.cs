using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Servicio
    {
        private int[] Lista;
        public int Contador;
        public Servicio()
        {
            Lista = new int[1000];
            Contador = 0;
        }
        private void Intercambiar(int i, int j)
        {
            int aux = Lista[i];
            Lista[i] = Lista[j];
            Lista[j] = aux;
        } 
        public void RegistrarValor(int valor)
        {
            Lista[Contador] = valor;
            Contador++;
        }
        public double CalcularPromedio()
        {
            double prom = 0;
            int ac = 0;
            if(Contador > 0)
           { for (int i = 0; i < Contador; i++)
            {
                ac += Lista[i];
            }
                prom = 1.0 * (ac / (double)Contador);
            }
            return prom;
        }
        public double CalcularMaximo()
        {
            double maximo = 0;
            for (int i = 0;i < Contador; i++)
            {
                if (Lista[i] > maximo) { maximo = Lista[i]; }
            }
            return maximo;
        }
        public double CalcularMinimo()
        {
            double minimo = 0;
            for (int i = 0; i < Contador; i++)
            {
                if(i == 0)
                {
                    minimo = Lista[i];
                }
                else
                {
                    if (Lista[i] < minimo)
                    {
                        minimo = Lista[i];
                    }
                }
            }
            return minimo;
        }
        public void OrdenarLista()
        {
            for (int i = 0; i < Contador; i++)
            {
                for(int j = i + 1; j < Contador; j++)
                {
                    if (Lista[i] > Lista[j])
                    {
                        Intercambiar(i, j);
                    }
                }
            }
        }
        public int BuscarValor(int buscado)
        {
            int idx = -1; int cont = 0;
            while(idx == -1 && cont < Contador)
            {
                if (Lista[cont] == buscado)
                {
                    idx = cont;
                }
                cont++;
            }
            return idx;
        }
        public double BuscarIndice(int idx)
        {
            int numero = Lista[idx];
            return numero;
        }
        public int[] ListaSuperioresAlPromedio(out int contadorSuperiores)
        {
            contadorSuperiores = 0; int[] superioresAlPromedio = new int[Contador];
            double prom = CalcularPromedio();
            for(int i = 0; i < Contador; i++)
            {
                if (Lista[i] >= prom)
                {
                    superioresAlPromedio[contadorSuperiores] = Lista[i];
                    contadorSuperiores++;
                }
            }
            return superioresAlPromedio;
        }
    }
}
