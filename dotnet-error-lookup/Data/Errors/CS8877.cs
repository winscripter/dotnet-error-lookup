namespace dotnet_error_lookup.Data.Errors;

public class CS8877 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8877";
    string IErrorOrWarning.Message => @"Record member '{0}' may not be static.";
    string IErrorOrWarning.Explanation => @"[original] Record member '{0}' may not be static.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
