namespace dotnet_error_lookup.Data.Errors;

public class CS1920 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1920";
    string IErrorOrWarning.Message => @"Element initializer cannot be empty";
    string IErrorOrWarning.Explanation => @"[original] Element initializer cannot be empty";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1920";
}
