namespace dotnet_error_lookup.Data.Errors;

public class CS0127 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0127";
    string IErrorOrWarning.Message => @"Since '{0}' returns void, a return keyword must not be followed by an object expression";
    string IErrorOrWarning.Explanation => @"[original] Since '{0}' returns void, a return keyword must not be followed by an object expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0127";
}
