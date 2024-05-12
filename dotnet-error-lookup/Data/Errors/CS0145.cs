namespace dotnet_error_lookup.Data.Errors;

public class CS0145 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0145";
    string IErrorOrWarning.Message => @"A const field requires a value to be provided";
    string IErrorOrWarning.Explanation => @"[original] A const field requires a value to be provided";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0145";
}
