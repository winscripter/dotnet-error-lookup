namespace dotnet_error_lookup.Data.Errors;

public class CS0138 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0138";
    string IErrorOrWarning.Message => @"A 'using namespace' directive can only be applied to namespaces; '{0}' is a type not a namespace. Consider a 'using static' directive instead";
    string IErrorOrWarning.Explanation => @"[original] A 'using namespace' directive can only be applied to namespaces; '{0}' is a type not a namespace. Consider a 'using static' directive instead";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0138";
}
