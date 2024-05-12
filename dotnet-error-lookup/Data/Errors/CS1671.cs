namespace dotnet_error_lookup.Data.Errors;

public class CS1671 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1671";
    string IErrorOrWarning.Message => @"A namespace declaration cannot have modifiers or attributes";
    string IErrorOrWarning.Explanation => @"[original] A namespace declaration cannot have modifiers or attributes";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1671";
}
