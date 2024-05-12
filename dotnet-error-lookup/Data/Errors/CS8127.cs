namespace dotnet_error_lookup.Data.Errors;

public class CS8127 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8127";
    string IErrorOrWarning.Message => @"Tuple element names must be unique.";
    string IErrorOrWarning.Explanation => @"[original] Tuple element names must be unique.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8127";
}
