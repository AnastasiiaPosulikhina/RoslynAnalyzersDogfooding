using ValueObjectGenerator;

namespace NET6SourceGeneratorUser;

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