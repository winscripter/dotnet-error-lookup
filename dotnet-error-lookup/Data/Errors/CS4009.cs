namespace dotnet_error_lookup.Data.Errors;

public class CS4009 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4009";
    string IErrorOrWarning.Message => @"A void or int returning entry point cannot be async";
    string IErrorOrWarning.Explanation => @"[original] A void or int returning entry point cannot be async";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/CS4009";
}
