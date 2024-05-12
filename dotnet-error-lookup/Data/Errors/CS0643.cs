namespace dotnet_error_lookup.Data.Errors;

public class CS0643 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0643";
    string IErrorOrWarning.Message => @"'{0}' duplicate named attribute argument";
    string IErrorOrWarning.Explanation => @"[original] '{0}' duplicate named attribute argument";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0643";
}
