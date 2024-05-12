namespace dotnet_error_lookup.Data.Errors;

public class CS1669 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1669";
    string IErrorOrWarning.Message => @"\_\_arglist is not valid in this context";
    string IErrorOrWarning.Explanation => @"[original] \_\_arglist is not valid in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
