using Microsoft.CodeAnalysis;

namespace CommentGenerator;

[Generator]
public class SourceGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext generatorContext)
    {
        generatorContext.RegisterSourceOutput(
            generatorContext.CompilationProvider,
            (context, compilation) => context.AddSource($"Hello-{compilation.AssemblyName}.cs", $"// Hello, {compilation.AssemblyName}! This is the changed message. "));
    }
}
