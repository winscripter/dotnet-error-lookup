namespace dotnet_error_lookup.Data.Errors;

public class CS8057 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8057";
    string IErrorOrWarning.Message => @"Block bodies and expression bodies cannot both be provided.";
    string IErrorOrWarning.Explanation => @"[original] Block bodies and expression bodies cannot both be provided.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
