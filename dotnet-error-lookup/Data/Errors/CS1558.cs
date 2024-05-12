namespace dotnet_error_lookup.Data.Errors;

public class CS1558 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1558";
    string IErrorOrWarning.Message => @"'{0}' does not have a suitable static 'Main' method";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not have a suitable static 'Main' method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1558";
}
