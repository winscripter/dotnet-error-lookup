namespace dotnet_error_lookup.Data.Errors;

public class CS8628 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8628";
    string IErrorOrWarning.Message => @"Cannot use a nullable reference type in object creation.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use a nullable reference type in object creation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
