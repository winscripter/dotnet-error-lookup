namespace dotnet_error_lookup.Data.Errors;

public class CS8416 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8416";
    string IErrorOrWarning.Message => @"Cannot use a collection of dynamic type in an asynchronous foreach";
    string IErrorOrWarning.Explanation => @"[original] Cannot use a collection of dynamic type in an asynchronous foreach";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
