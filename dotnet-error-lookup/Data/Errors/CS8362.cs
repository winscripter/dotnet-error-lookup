namespace dotnet_error_lookup.Data.Errors;

public class CS8362 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8362";
    string IErrorOrWarning.Message => @"\_\_arglist cannot have an argument of void type";
    string IErrorOrWarning.Explanation => @"[original] \_\_arglist cannot have an argument of void type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
