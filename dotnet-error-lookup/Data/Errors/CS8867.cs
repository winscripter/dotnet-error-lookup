namespace dotnet_error_lookup.Data.Errors;

public class CS8867 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8867";
    string IErrorOrWarning.Message => @"No accessible copy constructor found in base type '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] No accessible copy constructor found in base type '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
