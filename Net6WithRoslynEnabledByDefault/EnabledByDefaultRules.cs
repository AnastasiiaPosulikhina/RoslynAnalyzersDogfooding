using System.Collections.Generic;
using System.Linq;

namespace Net6WithRoslynEnabledByDefault;

public class EnabledByDefaultRules
{
    public void TestMethod()
    {
        /*
         * CA1851: Possible multiple enumerations of IEnumerable collection
         * Default severity: none
         * Quick fix: not available
         *
         * Проверить, как поведет себя Рослин при смене уровня анализа
         */
        IEnumerable<int> enumerable = Enumerable.Range(1, 10);
        var elementAt1 = enumerable.ElementAt(2);
        var elementAt2 = enumerable.ElementAt(2);
    }
}