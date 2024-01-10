using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_Dados_Spotify
{
    internal class Ordenacao
    {
        public static void selecao(List<Dataset> dados, ref int comp, ref int troca)
        {
            troca = 0;
            comp = 0;
            Dataset temp;
            int i, j, min;
            for (i = 0; i < dados.Count - 1; i++)
            {
                min = i;
                for (j = i + 1; j < dados.Count; j++)
                {
                    comp++;
                    if (String.Compare(dados[j].TrackName, dados[min].TrackName, StringComparison.Ordinal) < 0)
                    {
                        min = j;
                    }
                }
                temp = dados[i];
                dados[i] = dados[min];
                dados[min] = temp;
                troca++;
            }
        }
        public static void insercao(List<Dataset> dados, ref int comp, ref int troca)
        {
            troca = 0;
            comp = 0;
            Dataset temp;
            int i, j;
            for (i = 1; i < dados.Count; i++)
            {
                temp = dados[i];
                j = i - 1;
                comp++;
                while ((comp++ >= 0) && j >= 0 && String.Compare(temp.TrackName, dados[j].TrackName, StringComparison.Ordinal) < 0)
                {
                    dados[j + 1] = dados[j];
                    j--;
                }
                dados[j + 1] = temp;
                troca++;
            }
        }

        public static void Bolha(List<Dataset> dados, ref int comp, ref int troca)
        {
            int i, j;
            Dataset temp;
            troca = 0;
            comp = 0;
            for (i = 0; i < dados.Count - 1; i++)
            {
                for (j = dados.Count - 1; j > i; j--)
                {
                    if ((comp++ >= 0) && String.Compare(dados[j].TrackName, dados[j - 1].TrackName, StringComparison.Ordinal) < 0)
                    {
                        temp = dados[j];
                        dados[j] = dados[j - 1];
                        dados[j - 1] = temp;
                        troca++;
                    }
                }
            }
        }

        public static void shellSort(List<Dataset> dados, ref int comp, ref int troca)
        {
            troca = 0;
            comp = 0;
            Dataset x;
            int i, j, n;
            int h = 1;
            n = dados.Count;
            do
            {
                h = h * 3 + 1;
            } while (h <= n);
            do
            {
                h /= 3;
                for (i = h; i < n; i++)
                {
                    x = dados[i];
                    j = i;
                    while ((comp++ >= 0) && j > (h - 1) && String.Compare(x.TrackName, dados[j - h].TrackName, StringComparison.Ordinal) < 0)
                    {
                        dados[j] = dados[j - h];
                        j -= h;
                    }
                    troca++;
                    dados[j] = x;
                }
            } while (h != 1);
        }

        public static void quickSort(List<Dataset> dados, int esq, int dir, ref int comp, ref int troca)
        {
            int i, j;
            Dataset temp, x;

            x = dados[(esq + dir) / 2]; // pivo
            i = esq;
            j = dir;
            do
            {
                while (String.Compare(dados[i].TrackName, x.TrackName, StringComparison.Ordinal) < 0) 
                {
                    i++; 
                    comp++;
                }
                while (String.Compare(x.TrackName, dados[j].TrackName,  StringComparison.Ordinal) < 0) 
                { 
                    j--; 
                    comp++; 
                }
                if (i <= j)
                {
                    troca++;
                    temp = dados[i];
                    dados[i] = dados[j];
                    dados[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (esq < j) quickSort(dados, esq, j, ref comp, ref troca);
            if (i < dir) quickSort(dados, i, dir, ref comp, ref troca);
        }

    }
}
