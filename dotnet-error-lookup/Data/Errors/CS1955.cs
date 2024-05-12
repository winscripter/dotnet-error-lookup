namespace dotnet_error_lookup.Data.Errors;

public class CS1955 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1955";
    string IErrorOrWarning.Message => @"Non-invocable member '{0}' cannot be used like a method.";
    string IErrorOrWarning.Explanation => @"[original] Non-invocable member '{0}' cannot be used like a method.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1955";
}
