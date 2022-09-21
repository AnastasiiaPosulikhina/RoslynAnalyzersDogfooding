using Xunit;

namespace Net7WithPopularAnalyzersEnabledViaNuGet;

public class XUnit
{
    /*
     * xUnit1005: Fact methods should not have test data. Remove the test data, or convert the Fact to a Theory
     * Default severity: warning
     * Quick fix: available
     */
    [Fact, InlineData(1)]
    public void TestMethod()
    { }
}