namespace dotnet_error_lookup.Data.Errors;

public class CS2037 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2037";
    string IErrorOrWarning.Message => @"An expression tree lambda may not contain a COM call with ref omitted on arguments";
    string IErrorOrWarning.Explanation => @"[original] An expression tree lambda may not contain a COM call with ref omitted on arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
