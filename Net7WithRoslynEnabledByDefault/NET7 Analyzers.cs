using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Net7WithRoslynEnabledByDefault;

// New .NET 7 Analyzers: https://devblogs.microsoft.com/dotnet/performance_improvements_in_net_7/#analyzers

public interface IBaseInterface
{
    static abstract int Property { get; }
}

public interface IInterface : IBaseInterface
{
    static int IBaseInterface.Property => 10;
}

/*
 * CA1852: Seal internal/private types
 * Default severity: none
 * Quick fix: available, if severity is appropriately configured via .editorcondif/ruleset/etc
 */
internal class NewTest : Test
{
}



public partial class Test
{
    // GeneratedRegex source generator
    public static partial class MyUrlValidator
    {
        [GeneratedRegex(
            @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$", 
            RegexOptions.CultureInvariant, 
            matchTimeoutMilliseconds: 1000)]
        private static partial Regex MatchIfValidUrl();
        public static bool IsValidUrl(string url) => MatchIfValidUrl().IsMatch(url);
    }
    
    private Dictionary<int, string> _dictionary = new()
    {
        { 1, "string1" },
        { 2, "string2" },
    };

    private void Use(string value)
    {
        throw new NotImplementedException();
    }

    private readonly byte[] _data = RandomNumberGenerator.GetBytes(128);

    /*
     * CA1850: Prefer static HashData method over ComputeHash
     * Default severity: suggestion
     * Quick fix: available
     */
    public byte[] Hash1()
    {
        using (SHA256 h = SHA256.Create())
        {
            return h.ComputeHash(_data);
        }
    }

    public void TestMethod()
    {
        /*
         * CA1851: Possible multiple enumerations of IEnumerable collection
         * Default severity: none
         * Quick fix: not available
         */
        IEnumerable<int> enumerable = Enumerable.Range(1, 10);
        var elementAt1 = enumerable.ElementAt(2);
        var elementAt2 = enumerable.ElementAt(2);
        var elementAt3 = enumerable.ElementAt(2);
        var elementAt4 = enumerable.ElementAt(2);

        /*
         * SISLIB1045: Use 'GeneratedRegexAttribute' to generate the regular expression implementation at compile-time
         * Default severity: suggestion
         * Quick fix: available
         */
        Regex regex = new Regex(@"\G(\d{1,3})((?=(?:\d{3})+$))", RegexOptions.IgnoreCase);

        int key = 1;

        /*
         * CA1853: Do not guard 'Dictionary.Remove(key)' with 'Dictionary.ContainsKey(key)'
         * Default severity: suggestion
         * Quick fix: available
         */
        if (_dictionary.ContainsKey(key))
        {
            _dictionary.Remove(key);
        }

        /*
         * CA1854: Prefer the IDictionary.TryGetValue(TKey, out TValue) method
         * Default severity: suggestion
         * Quick fix: available
         */
        if (_dictionary.ContainsKey(key))
        {
            var val = _dictionary[key];
            Use(val);
        }
        
        Action disposeAction;
        IDisposable? disposable = null;
   
        if (disposable != null)
        {
            disposeAction = () => disposable.Dispose();
        }
    }
}
        
      