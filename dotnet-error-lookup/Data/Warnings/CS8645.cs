namespace dotnet_error_lookup.Data.Errors;

public class CS8645 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8645";
    string IErrorOrWarning.Message => @"'{0}' is already listed in the interface list on type '{1}' with different nullability of reference types.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is already listed in the interface list on type '{1}' with different nullability of reference types.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
