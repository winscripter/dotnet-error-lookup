namespace dotnet_error_lookup.Data.Errors;

public class CS8651 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8651";
    string IErrorOrWarning.Message => @"It is not legal to use nullable reference type '{0}?' in an as expression; use the underlying type '{0}' instead.";
    string IErrorOrWarning.Explanation => @"[original] It is not legal to use nullable reference type '{0}?' in an as expression; use the underlying type '{0}' instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
