namespace Net7WithPopularAnalyzersEnabledViaNuGet;

public class Roslynator_and_Sonar
{
    /*
     * RCS1213: Remove unused method declaration
     * Default severity: suggestion
     * Quick fix: available
    
     * S1144: Remove the unused private method 'TestMethod'
     * Default severity: suggestion
     * Quick fix: available
     */
    void TestMethod()
    {
        var x = Foo();

        object Foo()
        {
            throw new NotImplementedException();
        }
    }
}