# Default state of this solution
1. Roslyn analyzers are pre-installed in different ways:
   - NuGet package
   - reference to dll in csproj
   - csproj properties
   - Directory.Build.props
   - packages.config 
2. Roslyn analyzers have the following configuration in File | Settings | Editor | Inspection Settings | Roslyn Analyzers:
   - SWEA is enabled
   - Roslyn analyzers are enabled
   - Roslyn analyzers in SWEA are enabled
   - Reading settings from editorconfig, project settings and rule sets is enabled
3. Additional code analysis rules are mentioned in comments in csproj file for each project apart from NetCore31WithRoslynEnabledViaDirectoryBuildProps, where they are placed in Directory.Build.props. To enable them, it's necessary to uncomment th desired properties.
4. Solution items folder contains two global Roslyn analyzers settings files: editorconfig and Custom.ruleset. By default, projects in this particular solution read rules from the editorconfig file. To enable Custom.rulset, it's necessary to uncomment <CodeAnalysisRuleSet> property in the corresponding csproj.
5. Net5WithStyleCop also has a special config file stylecop.json.
6. Custom Roslyn analyzer is available in TestSimpleAnalyzer and has its' own config files.
7. Comments with the names of Roslyn's inspections show where they have to appear.
# How to work with this solution
Open [Roslyn Dogfooding checklist](https://jetbrains.team/p/net/documents/Rider/a/Roslyn-Dogfooding) and follow it.
