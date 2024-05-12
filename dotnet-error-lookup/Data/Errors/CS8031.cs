namespace dotnet_error_lookup.Data.Errors;

public class CS8031 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8031";
    string IErrorOrWarning.Message => @"Async lambda expression converted to a '{0}' returning delegate cannot return a value";
    string IErrorOrWarning.Explanation => @"[original] Async lambda expression converted to a '{0}' returning delegate cannot return a value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
