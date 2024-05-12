namespace dotnet_error_lookup.Data.Errors;

public class CS8857 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8857";
    string IErrorOrWarning.Message => @"The receiver of a `with` expression must have a non-void type.";
    string IErrorOrWarning.Explanation => @"[original] The receiver of a `with` expression must have a non-void type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
