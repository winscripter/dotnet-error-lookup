namespace dotnet_error_lookup.Data.Errors;

public class CS0060 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0060";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: base class '{1}' is less accessible than class '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: base class '{1}' is less accessible than class '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0060";
}
