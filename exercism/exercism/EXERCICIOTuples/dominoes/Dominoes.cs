using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOTuples.dominoes;
public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (dominoes.Count() == 0) return true;
        var ConvertDominoes = dominoes.ToList();
        var primeiro = ConvertDominoes.OrderBy(x => x.Item1 + x.Item2).First();
        ConvertDominoes.Remove(primeiro);
        var decrescente = ConvertDominoes.OrderByDescending(x => x.Item1 + x.Item2).ToList();
        var primeiroA = primeiro.Item1;
        var ladoB = primeiro.Item2;
        int count = decrescente.Count();
        while (count > 0)
        {
            foreach (var item in decrescente)
            {
                if (ladoB.Equals(item.Item1))
                {
                    ladoB = item.Item2;
                    decrescente.Remove(item);
                    break;
                }
                else if (ladoB.Equals(item.Item2))
                {
                    ladoB = item.Item1;
                    decrescente.Remove(item);
                    break;
                }
            }
            count--;
        }
        return primeiroA == ladoB && decrescente.Count == 0;
    }

    /*
    EXPLICAÇÃO DO RACICIONIO DO MESTRE MAICON QI 100000:

    1 - Ordernar a coleção das tuplas de suas somas dos valores, no caso o x.Item1 + x.Item2 e o seu resultado
    deve ser ordenado de menor para o maior
    2 - pegar o primeiro valor da ordem que foi ordenada de menor para o maior
    3 - depois disso, remover o primeiro valor da coleção ordenada
    4 - depois disso ordenar a coleção de Maior para menor
    5 - depois disso, o primeiro valor como base do inicio, o lado b dele, no caso o item2
    compare o valor que seja igual ao da coleção, onde que a coleção esta ordenada de maior para o menor
    E com isso, caso encontre o valor, faça com que elimine o valor que foi encontrado da coleção e
    ele vai tornar um valor referencia para percorrer nas coleções

     */
}
