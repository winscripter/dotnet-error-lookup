namespace dotnet_error_lookup.Data.Errors;

public class CS0061 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0061";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: base interface '{1}' is less accessible than interface '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: base interface '{1}' is less accessible than interface '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0061";
}
