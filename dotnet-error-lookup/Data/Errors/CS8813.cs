namespace dotnet_error_lookup.Data.Errors;

public class CS8813 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8813";
    string IErrorOrWarning.Message => @"A module initializer must be an ordinary member method";
    string IErrorOrWarning.Explanation => @"[original] A module initializer must be an ordinary member method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
