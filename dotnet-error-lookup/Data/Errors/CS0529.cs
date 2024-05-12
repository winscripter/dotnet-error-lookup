namespace dotnet_error_lookup.Data.Errors;

public class CS0529 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0529";
    string IErrorOrWarning.Message => @"Inherited interface '{1}' causes a cycle in the interface hierarchy of '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inherited interface '{1}' causes a cycle in the interface hierarchy of '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0529";
}
