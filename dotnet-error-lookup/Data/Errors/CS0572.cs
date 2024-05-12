namespace dotnet_error_lookup.Data.Errors;

public class CS0572 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0572";
    string IErrorOrWarning.Message => @"'{0}': cannot reference a type through an expression; try '{1}' instead";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot reference a type through an expression; try '{1}' instead";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0572";
}
