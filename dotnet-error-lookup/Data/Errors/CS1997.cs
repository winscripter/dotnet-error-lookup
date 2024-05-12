namespace dotnet_error_lookup.Data.Errors;

public class CS1997 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1997";
    string IErrorOrWarning.Message => @"Since '{0}' is an async method that returns '{1}', a return keyword must not be followed by an object expression";
    string IErrorOrWarning.Explanation => @"[original] Since '{0}' is an async method that returns '{1}', a return keyword must not be followed by an object expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1997";
}
