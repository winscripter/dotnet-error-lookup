namespace dotnet_error_lookup.Data.Errors;

public class CS9083 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9083";
    string IErrorOrWarning.Message => @"A member of '{0}' is returned by reference but was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.Explanation => @"[original] A member of '{0}' is returned by reference but was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
