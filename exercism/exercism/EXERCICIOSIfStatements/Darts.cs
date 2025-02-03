using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSIfStatements;
public static class Darts
{
    public static int Score(double x, double y)
    {
        var radius = Math.Sqrt(x * x + y * y);
        if (radius <= 1)
        {
            return 10;
        }
        else if (radius <= 5)
        {
            return 5;
        }
        else if (radius <= 10)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
