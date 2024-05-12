namespace dotnet_error_lookup.Data.Errors;

public class CS1767 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1767";
    string IErrorOrWarning.Message => @"Interface '{0}' has an invalid source interface which is required to embed event '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Interface '{0}' has an invalid source interface which is required to embed event '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
