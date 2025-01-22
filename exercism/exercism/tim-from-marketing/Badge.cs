using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.tim_from_marketing;

public static class Badge
{
    public static string Print(int? id, string name, string? department) =>
        $"{(id == null ? "" : $"[{id}] - ")}{name} - {department?.ToUpper() ?? "OWNER"}";
}
