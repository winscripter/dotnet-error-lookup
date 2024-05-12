namespace dotnet_error_lookup.Data.Errors;

public class CS8939 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8939";
    string IErrorOrWarning.Message => @"The #line directive end position must be greater than or equal to the start position";
    string IErrorOrWarning.Explanation => @"[original] The #line directive end position must be greater than or equal to the start position";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
