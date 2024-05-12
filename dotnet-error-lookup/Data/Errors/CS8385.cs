namespace dotnet_error_lookup.Data.Errors;

public class CS8385 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8385";
    string IErrorOrWarning.Message => @"The given expression cannot be used in a fixed statement";
    string IErrorOrWarning.Explanation => @"[original] The given expression cannot be used in a fixed statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
