namespace dotnet_error_lookup.Data.Errors;

public class CS8888 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8888";
    string IErrorOrWarning.Message => @"'managed' calling convention cannot be combined with unmanaged calling convention specifiers.";
    string IErrorOrWarning.Explanation => @"[original] 'managed' calling convention cannot be combined with unmanaged calling convention specifiers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
