namespace dotnet_error_lookup.Data.Errors;

public class CS8506 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8506";
    string IErrorOrWarning.Message => @"No best type was found for the switch expression.";
    string IErrorOrWarning.Explanation => @"[original] No best type was found for the switch expression.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
