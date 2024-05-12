namespace dotnet_error_lookup.Data.Errors;

public class CS8891 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8891";
    string IErrorOrWarning.Message => @"Type '{0}' must be public to be used as a calling convention.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' must be public to be used as a calling convention.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
