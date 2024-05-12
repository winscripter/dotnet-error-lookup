namespace dotnet_error_lookup.Data.Errors;

public class CS1573 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1573";
    string IErrorOrWarning.Message => @"Parameter '{0}' has no matching param tag in the XML comment for '{1}' (but other parameters do)";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' has no matching param tag in the XML comment for '{1}' (but other parameters do)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1573";
}
