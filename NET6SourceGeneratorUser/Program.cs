// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// DisableDateTimeNow
var now = DateTime.Now;
Console.WriteLine(now);

// NJsonGenerator
// EXPECTED: GeneratedSchemas is resolved successfully
var obj = new GeneratedSchemas.Anonymous { Object = new GeneratedSchemas.Object { A = "A", C = "C", E = "E" }, String = "String" };
Console.WriteLine(obj.ToJson());
