namespace dotnet_error_lookup.Data.Errors;

public class CS1104 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1104";
    string IErrorOrWarning.Message => @"A parameter array cannot be used with 'this' modifier on an extension method";
    string IErrorOrWarning.Explanation => @"[original] A parameter array cannot be used with 'this' modifier on an extension method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1104";
}
