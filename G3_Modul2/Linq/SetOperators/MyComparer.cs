using System.Diagnostics.CodeAnalysis;

namespace G3_Modul2.Linq.SetOperators;

public class MyComparer : IEqualityComparer<string>, IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return x.Equals(y, StringComparison.OrdinalIgnoreCase) ? 0 : 1;
    }

    public bool Equals(string? x, string? y)
    {
        return x.ToLower() == y.ToLower();// x.Equals(y, StringComparison.OrdinalIgnoreCase);
    }

    public int GetHashCode([DisallowNull] string obj)
    {
        return obj.GetHashCode();
    }
}
