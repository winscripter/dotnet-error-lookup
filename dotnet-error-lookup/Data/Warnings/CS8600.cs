namespace dotnet_error_lookup.Data.Errors;

public class CS8600 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8600";
    string IErrorOrWarning.Message => @"Converting null literal or possible null value to non-nullable type.";
    string IErrorOrWarning.Explanation => @"[original] Converting null literal or possible null value to non-nullable type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
