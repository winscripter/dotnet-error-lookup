namespace dotnet_error_lookup.Data.Errors;

public class CS8113 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8113";
    string IErrorOrWarning.Message => @"Invalid hash algorithm name: '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Invalid hash algorithm name: '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
