namespace dotnet_error_lookup.Data.Errors;

public class CS1615 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1615";
    string IErrorOrWarning.Message => @"Argument {0} may not be passed with the '{1}' keyword";
    string IErrorOrWarning.Explanation => @"[original] Argument {0} may not be passed with the '{1}' keyword";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1615";
}
