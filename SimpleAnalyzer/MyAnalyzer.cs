using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace SimpleAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class MyAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "MEOW7777";
        private const string Title = "Test Custom Analyzer";
        private const string MessageFormat = "Hey! We are testing custom analyzers here! Meow-wow!";
        private const string Description = "Test Custom Analyzer";
        private const string Category = "Usage";

        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat,
            Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.EnableConcurrentExecution();
            context.RegisterOperationAction(AnalyzeNode, OperationKind.Invocation);
        }

        private static void AnalyzeNode(OperationAnalysisContext operationAnalysisContext)
        {
            var invocationOperation = (IInvocationOperation)operationAnalysisContext.Operation;

            if (invocationOperation.TargetMethod.Name != "Meow")
                return;

            var diagnostic = Diagnostic.Create(Rule, invocationOperation.Syntax.GetLocation());
            operationAnalysisContext.ReportDiagnostic(diagnostic);
        }

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);
    }
}