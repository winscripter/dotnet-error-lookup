namespace dotnet_error_lookup.Data.Errors;

public class CS8625 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8625";
    string IErrorOrWarning.Message => @"Cannot convert null literal to non-nullable reference type.";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert null literal to non-nullable reference type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
