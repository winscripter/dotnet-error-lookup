namespace dotnet_error_lookup.Data.Errors;

public class CS8307 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8307";
    string IErrorOrWarning.Message => @"The first operand of an 'as' operator may not be a tuple literal without a natural type.";
    string IErrorOrWarning.Explanation => @"[original] The first operand of an 'as' operator may not be a tuple literal without a natural type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
