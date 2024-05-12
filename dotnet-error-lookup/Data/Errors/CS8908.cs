namespace dotnet_error_lookup.Data.Errors;

public class CS8908 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8908";
    string IErrorOrWarning.Message => @"The type '{0}' may not be used for a field of a record.";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' may not be used for a field of a record.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
