namespace dotnet_error_lookup.Data.Errors;

public class CS8788 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8788";
    string IErrorOrWarning.Message => @"Cannot use an extension method with a receiver as the target of a '&' operator.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use an extension method with a receiver as the target of a '&' operator.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
