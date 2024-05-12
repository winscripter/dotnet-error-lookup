namespace dotnet_error_lookup.Data.Errors;

public class CS8141 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8141";
    string IErrorOrWarning.Message => @"The tuple element names in the signature of method '{0}' must match the tuple element names of interface method '{1}' (including on the return type).";
    string IErrorOrWarning.Explanation => @"[original] The tuple element names in the signature of method '{0}' must match the tuple element names of interface method '{1}' (including on the return type).";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8141";
}
