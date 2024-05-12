namespace dotnet_error_lookup.Data.Errors;

public class CS8181 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8181";
    string IErrorOrWarning.Message => @"'new' cannot be used with tuple type. Use a tuple literal expression instead.";
    string IErrorOrWarning.Explanation => @"[original] 'new' cannot be used with tuple type. Use a tuple literal expression instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
