namespace dotnet_error_lookup.Data.Errors;

public class CS8958 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8958";
    string IErrorOrWarning.Message => @"The parameterless struct constructor must be 'public'.";
    string IErrorOrWarning.Explanation => @"[original] The parameterless struct constructor must be 'public'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
