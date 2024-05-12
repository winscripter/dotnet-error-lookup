namespace dotnet_error_lookup.Data.Errors;

public class CS1620 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1620";
    string IErrorOrWarning.Message => @"Argument {0} must be passed with the '{1}' keyword";
    string IErrorOrWarning.Explanation => @"[original] Argument {0} must be passed with the '{1}' keyword";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1620";
}
