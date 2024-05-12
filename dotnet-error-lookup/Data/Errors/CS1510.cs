namespace dotnet_error_lookup.Data.Errors;

public class CS1510 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1510";
    string IErrorOrWarning.Message => @"A ref or out value must be an assignable variable";
    string IErrorOrWarning.Explanation => @"[original] A ref or out value must be an assignable variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1510";
}
