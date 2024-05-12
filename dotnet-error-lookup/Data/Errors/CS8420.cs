namespace dotnet_error_lookup.Data.Errors;

public class CS8420 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8420";
    string IErrorOrWarning.Message => @"The body of an async-iterator method must contain a 'yield' statement. Consider removing 'async' from the method declaration or adding a 'yield' statement.";
    string IErrorOrWarning.Explanation => @"[original] The body of an async-iterator method must contain a 'yield' statement. Consider removing 'async' from the method declaration or adding a 'yield' statement.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
