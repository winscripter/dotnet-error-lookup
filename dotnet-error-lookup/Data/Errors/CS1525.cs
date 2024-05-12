namespace dotnet_error_lookup.Data.Errors;

public class CS1525 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1525";
    string IErrorOrWarning.Message => @"Invalid expression term '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Invalid expression term '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1525";
}
