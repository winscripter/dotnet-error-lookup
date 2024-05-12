namespace dotnet_error_lookup.Data.Errors;

public class CS8864 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8864";
    string IErrorOrWarning.Message => @"Records may only inherit from object or another record";
    string IErrorOrWarning.Explanation => @"[original] Records may only inherit from object or another record";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
