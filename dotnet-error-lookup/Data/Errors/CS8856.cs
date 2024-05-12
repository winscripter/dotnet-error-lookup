namespace dotnet_error_lookup.Data.Errors;

public class CS8856 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8856";
    string IErrorOrWarning.Message => @"The 'init' accessor is not valid on static members";
    string IErrorOrWarning.Explanation => @"[original] The 'init' accessor is not valid on static members";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
