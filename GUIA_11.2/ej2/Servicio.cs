using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    internal class Servicio
    {
        public string[] Nombres;
        public int[] Libretas;
        public double[] Notas;
        public int Cantidad;
        public Servicio()
        {
            Nombres = new string[20];
            Libretas = new int[20];
            Notas = new double[20];
            Cantidad = 0;
        }
        public bool RegistrarAlumno(int libreta, string nombre, double nota)
        {
            bool registro = false;
            if (Cantidad < 19)
            {
                registro = true;
                Nombres[Cantidad] = nombre;
                Libretas[Cantidad] = libreta;
                Notas[Cantidad] = nota;
                Cantidad++;
            }
            return registro;
        }
        public double CalcularPromedio()
        {
            double prom = 0; double ac = 0;
            if (Cantidad > 0)
            {
                for(int i = 0; i < Cantidad; i++)
                {
                    ac += Notas[i];
                }
                prom = ac / Cantidad;
            }
            return prom;
        }
        public int CalcularAlumnoMayorNota()
        {
            int idx = 0;
            for (int i = 0; i < Cantidad; i++)
            {
                if (Notas[i] > Notas[idx])
                {
                    idx = i;
                }
            }
            return idx;
        }
        public int CalcularAlumnoMenorNota()
        {
            int idx = 0;
            for (int i = 0; i < Cantidad; i++)
            {
                if (Notas[i] < Notas[idx])
                {
                    idx = i;
                }
            }
            return idx;
        }
        public void OrdenadaAlumnosPorLibreta()
        {
            for( int i = 0;i < Cantidad - 1; i++)
            {
                for(int j = i + 1; j < Cantidad; j++)
                {
                    if (Libretas[i] > Libretas[j])
                    {
                        int auxlib = Libretas[i];
                        Libretas[i] = Libretas[j];
                        Libretas[j] = auxlib;
                        string auxnom = Nombres[i];
                        Nombres[i] = Nombres[j];
                        Nombres[j] = auxnom;
                        double auxnot = Notas[i];
                        Notas[i] = Notas[j];
                        Notas[j] = auxnot;
                    }
                }
            }
        }
        public int BuscarValor(int valor)
        {
            int idx = -1; int cont = 0;
            while(idx == -1 && cont < Cantidad)
            {
                if (Notas[cont] == valor)
                {
                    idx = cont;
                }
                cont++;
            }
            return idx;
        }
        public int BuscarPorLibreta(int libreta)
        {
            int idx = -1; int cont = 0;
            while(idx == -1 && cont < Cantidad)
            {
                if(Libretas[cont] == libreta)
                {
                    idx = cont;
                }
                cont++;
            }
            return idx;
        }
        public int[] ListarAlumnosSuperaronElPromedio(out int cantidadMayores)
        {
            cantidadMayores = 0;
            int[] listaSuperioresAlPromedio = new int[Cantidad];
            double prom = CalcularPromedio();
            for(int i = 0; i < Cantidad; i++)
            {
                if (Notas[i] > prom)
                {
                    listaSuperioresAlPromedio[cantidadMayores] = i;
                    cantidadMayores++;
                }
            }
            return listaSuperioresAlPromedio;
        }
    }
}
