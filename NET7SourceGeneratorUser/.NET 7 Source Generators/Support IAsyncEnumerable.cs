using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace NET7SourceGeneratorUser.NET_7_Source_Generators;

// .NET 7 change: https://github.com/dotnet/runtime/issues/59268

[JsonSerializable(typeof(MyPoco))]
public class MyContext : JsonSerializerContext
{
    public MyContext(JsonSerializerOptions? options) : base(options)
    {
    }

    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        throw new NotImplementedException();
    }

    protected override JsonSerializerOptions? GeneratedSerializerOptions { get; }
    public static JsonSerializerOptions? MyPoco { get; set; }
}
public class MyPoco
{
    // Use of IAsyncEnumerable that previously resulted 
    // in JsonSerializer.Serialize() throwing NotSupportedException 
    public IAsyncEnumerable<int> Data { get; set; }

    public void TestMethod()
    {
        // It now works and no longer throws NotSupportedException
        JsonSerializer.Serialize(new MyPoco(), MyContext.MyPoco);
    }
}


