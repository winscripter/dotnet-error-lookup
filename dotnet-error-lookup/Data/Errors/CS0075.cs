namespace dotnet_error_lookup.Data.Errors;

public class CS0075 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0075";
    string IErrorOrWarning.Message => @"To cast a negative value, you must enclose the value in parentheses.";
    string IErrorOrWarning.Explanation => @"[original] To cast a negative value, you must enclose the value in parentheses.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0075";
}
