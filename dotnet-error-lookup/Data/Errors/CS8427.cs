namespace dotnet_error_lookup.Data.Errors;

public class CS8427 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8427";
    string IErrorOrWarning.Message => @"Enums, classes, and structures cannot be declared in an interface that has an 'in' or 'out' type parameter.";
    string IErrorOrWarning.Explanation => @"[original] Enums, classes, and structures cannot be declared in an interface that has an 'in' or 'out' type parameter.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
