namespace dotnet_error_lookup.Data.Errors;

public class CS8799 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8799";
    string IErrorOrWarning.Message => @"Both partial method declarations must have identical accessibility modifiers.";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must have identical accessibility modifiers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
