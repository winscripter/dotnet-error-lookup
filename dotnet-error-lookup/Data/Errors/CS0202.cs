namespace dotnet_error_lookup.Data.Errors;

public class CS0202 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0202";
    string IErrorOrWarning.Message => @"foreach requires that the return type '{0}' of '{1}' must have a suitable public 'MoveNext' method and public 'Current' property";
    string IErrorOrWarning.Explanation => @"[original] foreach requires that the return type '{0}' of '{1}' must have a suitable public 'MoveNext' method and public 'Current' property";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0202";
}
