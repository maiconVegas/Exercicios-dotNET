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
}
