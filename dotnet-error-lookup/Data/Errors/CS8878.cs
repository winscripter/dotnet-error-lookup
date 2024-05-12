namespace dotnet_error_lookup.Data.Errors;

public class CS8878 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8878";
    string IErrorOrWarning.Message => @"A copy constructor '{0}' must be public or protected because the record is not sealed.";
    string IErrorOrWarning.Explanation => @"[original] A copy constructor '{0}' must be public or protected because the record is not sealed.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
