namespace dotnet_error_lookup.Data.Errors;

public class CS8933 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Hidden;
    string IErrorOrWarning.Name => @"CS8933";
    string IErrorOrWarning.Message => @"The using directive for '{0}' appeared previously as global using";
    string IErrorOrWarning.Explanation => @"[original] The using directive for '{0}' appeared previously as global using";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
