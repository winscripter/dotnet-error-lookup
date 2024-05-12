namespace dotnet_error_lookup.Data.Errors;

public class CS0677 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0677";
    string IErrorOrWarning.Message => @"'{0}': a volatile field cannot be of the type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a volatile field cannot be of the type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0677";
}
