namespace dotnet_error_lookup.Data.Errors;

public class CS0177 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0177";
    string IErrorOrWarning.Message => @"The out parameter '{0}' must be assigned to before control leaves the current method";
    string IErrorOrWarning.Explanation => @"[original] The out parameter '{0}' must be assigned to before control leaves the current method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0177";
}
