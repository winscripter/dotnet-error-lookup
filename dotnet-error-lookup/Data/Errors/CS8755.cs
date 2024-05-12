namespace dotnet_error_lookup.Data.Errors;

public class CS8755 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8755";
    string IErrorOrWarning.Message => @"'{0}' cannot be used as a modifier on a function pointer parameter.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be used as a modifier on a function pointer parameter.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
