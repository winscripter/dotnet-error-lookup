namespace dotnet_error_lookup.Data.Errors;

public class CS9040 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9040";
    string IErrorOrWarning.Message => @"'{2}' cannot satisfy the 'new()' constraint on parameter '{1}' in the generic type or or method '{0}' because '{2}' has required members.";
    string IErrorOrWarning.Explanation => @"[original] '{2}' cannot satisfy the 'new()' constraint on parameter '{1}' in the generic type or or method '{0}' because '{2}' has required members.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
