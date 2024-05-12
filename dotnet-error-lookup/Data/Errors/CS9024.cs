namespace dotnet_error_lookup.Data.Errors;

public class CS9024 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9024";
    string IErrorOrWarning.Message => @"An 'implicit' user-defined conversion operator cannot be declared checked";
    string IErrorOrWarning.Explanation => @"[original] An 'implicit' user-defined conversion operator cannot be declared checked";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
