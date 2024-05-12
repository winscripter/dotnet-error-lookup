namespace dotnet_error_lookup.Data.Errors;

public class CS8907 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8907";
    string IErrorOrWarning.Message => @"Parameter '{0}' is unread. Did you forget to use it to initialize the property with that name?";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' is unread. Did you forget to use it to initialize the property with that name?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
