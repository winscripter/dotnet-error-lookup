namespace dotnet_error_lookup.Data.Errors;

public class CS8780 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8780";
    string IErrorOrWarning.Message => @"A variable may not be declared within a 'not' or 'or' pattern.";
    string IErrorOrWarning.Explanation => @"[original] A variable may not be declared within a 'not' or 'or' pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
