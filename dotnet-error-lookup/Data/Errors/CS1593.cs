namespace dotnet_error_lookup.Data.Errors;

public class CS1593 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1593";
    string IErrorOrWarning.Message => @"Delegate '{0}' does not take {1} arguments";
    string IErrorOrWarning.Explanation => @"[original] Delegate '{0}' does not take {1} arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1593";
}
