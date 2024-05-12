namespace dotnet_error_lookup.Data.Errors;

public class CS8419 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8419";
    string IErrorOrWarning.Message => @"The body of an async-iterator method must contain a 'yield' statement.";
    string IErrorOrWarning.Explanation => @"[original] The body of an async-iterator method must contain a 'yield' statement.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
