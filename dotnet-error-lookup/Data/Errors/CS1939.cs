namespace dotnet_error_lookup.Data.Errors;

public class CS1939 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1939";
    string IErrorOrWarning.Message => @"Cannot pass the range variable '{0}' as an out or ref parameter";
    string IErrorOrWarning.Explanation => @"[original] Cannot pass the range variable '{0}' as an out or ref parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1939";
}
