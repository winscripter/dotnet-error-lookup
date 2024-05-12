namespace dotnet_error_lookup.Data.Errors;

public class CS1535 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1535";
    string IErrorOrWarning.Message => @"Overloaded unary operator '{0}' takes one parameter";
    string IErrorOrWarning.Explanation => @"[original] Overloaded unary operator '{0}' takes one parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1535";
}
