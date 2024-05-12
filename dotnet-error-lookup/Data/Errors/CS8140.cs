namespace dotnet_error_lookup.Data.Errors;

public class CS8140 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8140";
    string IErrorOrWarning.Message => @"'{0}' is already listed in the interface list on type '{2}' with different tuple element names, as '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is already listed in the interface list on type '{2}' with different tuple element names, as '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8140";
}
