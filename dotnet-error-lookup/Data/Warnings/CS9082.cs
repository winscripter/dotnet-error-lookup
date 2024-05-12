namespace dotnet_error_lookup.Data.Errors;

public class CS9082 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9082";
    string IErrorOrWarning.Message => @"Local '{0}' is returned by reference but was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.Explanation => @"[original] Local '{0}' is returned by reference but was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
