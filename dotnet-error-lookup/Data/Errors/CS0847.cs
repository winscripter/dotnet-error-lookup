namespace dotnet_error_lookup.Data.Errors;

public class CS0847 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0847";
    string IErrorOrWarning.Message => @"An array initializer of length '{0}' is expected";
    string IErrorOrWarning.Explanation => @"[original] An array initializer of length '{0}' is expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
