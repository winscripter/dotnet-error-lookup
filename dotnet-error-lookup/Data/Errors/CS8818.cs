namespace dotnet_error_lookup.Data.Errors;

public class CS8818 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8818";
    string IErrorOrWarning.Message => @"Partial method declarations must have matching ref return values.";
    string IErrorOrWarning.Explanation => @"[original] Partial method declarations must have matching ref return values.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
