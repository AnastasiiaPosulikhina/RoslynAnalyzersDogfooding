using System;
using ValueObjectGenerator;

namespace NETFramework48SourceGeneratorUser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DisableDateTimeNow
            var now = DateTime.Now;
            Console.WriteLine(now);
            
            // NJsonGenerator
            // EXPECTED: GeneratedSchemas is resolved successfully
            var obj = new GeneratedSchemas.Anonymous { Object = new GeneratedSchemas.Object { A = "A", C = "C", E = "E" }, String = "String" };
            Console.WriteLine(obj.ToJson());
        }
    }
    
    // ValueObjectGenerator
    // EXPECTED: attributes are properly resolved
    [StringValueObject]
    public partial class UserName
    {
    }

    [StringValueObject(PropertyName = "StringValue")]
    public partial class CustomizedPropertyName
    {
    }

    [IntValueObject]
    public partial class ProductId
    {
    }

    [IntValueObject]
    public partial class CategoryId
    {
    }

    [LongValueObject]
    public partial class ConsumeId
    {
    }

    [FloatValueObject]
    public partial class Scale
    {
    }

    [DoubleValueObject]
    public partial class Rate
    {
    }
}