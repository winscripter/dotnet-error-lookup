namespace dotnet_error_lookup.Data.Errors;

public class CS1984 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1984";
    string IErrorOrWarning.Message => @"Cannot await in the body of a finally clause";
    string IErrorOrWarning.Explanation => @"[original] Cannot await in the body of a finally clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
