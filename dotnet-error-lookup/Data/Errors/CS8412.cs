namespace dotnet_error_lookup.Data.Errors;

public class CS8412 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8412";
    string IErrorOrWarning.Message => @"Asynchronous foreach requires that the return type '{0}' of '{1}' must have a suitable public 'MoveNextAsync' method and public 'Current' property";
    string IErrorOrWarning.Explanation => @"[original] Asynchronous foreach requires that the return type '{0}' of '{1}' must have a suitable public 'MoveNextAsync' method and public 'Current' property";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
