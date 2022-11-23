// See https://aka.ms/new-console-template for more information
using NET7SourceGeneratorUser.NET_7_Source_Generators;


// General

// DisableDateTimeNow
var now = DateTime.Now;
Console.WriteLine(now);

// NJsonGenerator
// EXPECTED: GeneratedSchemas is resolved successfully
var obj = new GeneratedSchemas.Anonymous { Object = new GeneratedSchemas.Object { A = "A", C = "C", E = "E" }, String = "String" };
Console.WriteLine(obj.ToJson());

// .NET 7

// Support IAsyncEnumerable
// EXPECTED: the code snippet runs successfully without exceptions
MyPoco myPoco = new MyPoco();
myPoco.TestMethod();

// Support DateOnly and TimeOnly in JsonSerialize
// EXPECTED: the code snippet runs successfully without exceptions
SupportDateOnlyAndTimeOnlyInJsonSerialize test = new SupportDateOnlyAndTimeOnlyInJsonSerialize();
test.TestMethod();
