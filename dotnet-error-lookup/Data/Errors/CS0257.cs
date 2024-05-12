namespace dotnet_error_lookup.Data.Errors;

public class CS0257 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0257";
    string IErrorOrWarning.Message => @"An \_\_arglist parameter must be the last parameter in a parameter list";
    string IErrorOrWarning.Explanation => @"[original] An \_\_arglist parameter must be the last parameter in a parameter list";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
