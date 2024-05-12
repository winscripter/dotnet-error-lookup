namespace dotnet_error_lookup.Data.Errors;

public class CS0626 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0626";
    string IErrorOrWarning.Message => @"Method, operator, or accessor '{0}' is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation.";
    string IErrorOrWarning.Explanation => @"[original] Method, operator, or accessor '{0}' is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0626";
}
