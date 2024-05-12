namespace dotnet_error_lookup.Data.Errors;

public class CS1985 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1985";
    string IErrorOrWarning.Message => @"Cannot await in a catch clause";
    string IErrorOrWarning.Explanation => @"[original] Cannot await in a catch clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
