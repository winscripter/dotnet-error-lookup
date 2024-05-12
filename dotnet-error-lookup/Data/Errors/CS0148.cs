namespace dotnet_error_lookup.Data.Errors;

public class CS0148 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0148";
    string IErrorOrWarning.Message => @"The delegate '{0}' does not have a valid constructor";
    string IErrorOrWarning.Explanation => @"[original] The delegate '{0}' does not have a valid constructor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0148";
}
