namespace dotnet_error_lookup.Data.Errors;

public class CS1106 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1106";
    string IErrorOrWarning.Message => @"Extension method must be defined in a non-generic static class";
    string IErrorOrWarning.Explanation => @"[original] Extension method must be defined in a non-generic static class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1106";
}
