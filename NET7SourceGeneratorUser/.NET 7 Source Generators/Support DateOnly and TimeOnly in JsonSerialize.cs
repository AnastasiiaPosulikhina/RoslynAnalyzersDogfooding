using System.Text.Json;

namespace NET7SourceGeneratorUser.NET_7_Source_Generators;

// .NET 7 change: https://github.com/dotnet/runtime/issues/53539

public class SupportDateOnlyAndTimeOnlyInJsonSerialize
{
    public record DataTypeTest(DateOnly Date, TimeOnly Time);
    
    public void TestMethod()
    {
        var date = DateOnly.FromDateTime(DateTime.Now);
        var time = TimeOnly.FromDateTime(DateTime.Now);

        var test = new DataTypeTest(date, time);
        var json = JsonSerializer.Serialize(test);
    }
}