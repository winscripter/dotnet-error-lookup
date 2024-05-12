namespace dotnet_error_lookup.Data.Errors;

public class CS9131 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9131";
    string IErrorOrWarning.Message => @"Only a 'using static' or 'using alias' can be 'unsafe'.";
    string IErrorOrWarning.Explanation => @"[original] Only a 'using static' or 'using alias' can be 'unsafe'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
