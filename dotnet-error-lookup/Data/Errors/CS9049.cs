namespace dotnet_error_lookup.Data.Errors;

public class CS9049 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9049";
    string IErrorOrWarning.Message => @"A fixed field must not be a ref field.";
    string IErrorOrWarning.Explanation => @"[original] A fixed field must not be a ref field.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
