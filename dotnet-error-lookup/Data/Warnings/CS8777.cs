namespace dotnet_error_lookup.Data.Errors;

public class CS8777 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8777";
    string IErrorOrWarning.Message => @"Parameter '{0}' must have a non-null value when exiting.";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' must have a non-null value when exiting.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
