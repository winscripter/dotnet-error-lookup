namespace dotnet_error_lookup.Data.Errors;

public class CS0056 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0056";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: return type '{1}' is less accessible than operator '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: return type '{1}' is less accessible than operator '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0056";
}
