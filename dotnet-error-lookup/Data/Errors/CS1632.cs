namespace dotnet_error_lookup.Data.Errors;

public class CS1632 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1632";
    string IErrorOrWarning.Message => @"Control cannot leave the body of an anonymous method or lambda expression";
    string IErrorOrWarning.Explanation => @"[original] Control cannot leave the body of an anonymous method or lambda expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1632";
}
