using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOTuples.saddle_points
{
    public static class SaddlePoints
    {
        public static IEnumerable<(int, int)> Calculate(int[,] matrix)
        {
            var linhas = matrix.GetLength(0);
            var colunas = matrix.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    int valor = matrix[i, j];
                    var maiorLinha = Enumerable.Range(0, colunas).Select(c => matrix[i, c]).Max();
                    var menorColuna = Enumerable.Range(0, linhas).Select(l => matrix[l, j]).Min();
                    if (valor == maiorLinha && valor == menorColuna)
                    {
                        yield return (i+1, j+1);
                    }
                }
            }
        }
    }
}
