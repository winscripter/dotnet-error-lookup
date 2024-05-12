namespace dotnet_error_lookup.Data.Errors;

public class CS0175 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0175";
    string IErrorOrWarning.Message => @"Use of keyword 'base' is not valid in this context";
    string IErrorOrWarning.Explanation => @"[original] Use of keyword 'base' is not valid in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0175";
}
