namespace dotnet_error_lookup.Data.Errors;

public class CS2029 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS2029";
    string IErrorOrWarning.Message => @"Invalid name for a preprocessing symbol; '{0}' is not a valid identifier";
    string IErrorOrWarning.Explanation => @"[original] Invalid name for a preprocessing symbol; '{0}' is not a valid identifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2029";
}
