namespace dotnet_error_lookup.Data.Errors;

public class CS1764 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1764";
    string IErrorOrWarning.Message => @"Cannot use fixed local '{0}' inside an anonymous method, lambda expression, or query expression";
    string IErrorOrWarning.Explanation => @"[original] Cannot use fixed local '{0}' inside an anonymous method, lambda expression, or query expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
