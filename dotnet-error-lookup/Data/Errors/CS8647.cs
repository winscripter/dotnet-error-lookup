namespace dotnet_error_lookup.Data.Errors;

public class CS8647 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8647";
    string IErrorOrWarning.Message => @"A using variable cannot be used directly within a switch section (consider using braces). ";
    string IErrorOrWarning.Explanation => @"[original] A using variable cannot be used directly within a switch section (consider using braces). ";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
