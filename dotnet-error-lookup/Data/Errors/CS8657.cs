namespace dotnet_error_lookup.Data.Errors;

public class CS8657 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8657";
    string IErrorOrWarning.Message => @"Static member '{0}' cannot be marked 'readonly'.";
    string IErrorOrWarning.Explanation => @"[original] Static member '{0}' cannot be marked 'readonly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
