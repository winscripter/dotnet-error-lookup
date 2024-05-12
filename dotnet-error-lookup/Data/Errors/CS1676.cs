namespace dotnet_error_lookup.Data.Errors;

public class CS1676 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1676";
    string IErrorOrWarning.Message => @"Parameter {0} must be declared with the '{1}' keyword";
    string IErrorOrWarning.Explanation => @"[original] Parameter {0} must be declared with the '{1}' keyword";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1676";
}
