namespace dotnet_error_lookup.Data.Errors;

public class CS0542 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0542";
    string IErrorOrWarning.Message => @"'{0}': member names cannot be the same as their enclosing type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': member names cannot be the same as their enclosing type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0542";
}
