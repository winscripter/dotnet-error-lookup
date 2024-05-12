namespace dotnet_error_lookup.Data.Errors;

public class CS8859 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8859";
    string IErrorOrWarning.Message => @"Members named 'Clone' are disallowed in records.";
    string IErrorOrWarning.Explanation => @"[original] Members named 'Clone' are disallowed in records.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
