namespace dotnet_error_lookup.Data.Errors;

public class CS1636 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1636";
    string IErrorOrWarning.Message => @"\_\_arglist is not allowed in the parameter list of iterators";
    string IErrorOrWarning.Explanation => @"[original] \_\_arglist is not allowed in the parameter list of iterators";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
