namespace dotnet_error_lookup.Data.Errors;

public class CS4029 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4029";
    string IErrorOrWarning.Message => @"Cannot return an expression of type 'void'";
    string IErrorOrWarning.Explanation => @"[original] Cannot return an expression of type 'void'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
