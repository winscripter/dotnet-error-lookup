namespace dotnet_error_lookup.Data.Errors;

public class CS8199 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8199";
    string IErrorOrWarning.Message => @"The syntax 'var (...)' as an lvalue is reserved.";
    string IErrorOrWarning.Explanation => @"[original] The syntax 'var (...)' as an lvalue is reserved.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
