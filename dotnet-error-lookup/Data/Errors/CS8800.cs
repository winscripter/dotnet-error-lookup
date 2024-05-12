namespace dotnet_error_lookup.Data.Errors;

public class CS8800 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8800";
    string IErrorOrWarning.Message => @"Both partial method declarations must have identical combinations of 'virtual', 'override', 'sealed', and 'new' modifiers.";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must have identical combinations of 'virtual', 'override', 'sealed', and 'new' modifiers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
