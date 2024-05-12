namespace dotnet_error_lookup.Data.Errors;

public class CS8125 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8125";
    string IErrorOrWarning.Message => @"Tuple element name '{0}' is only allowed at position {1}.";
    string IErrorOrWarning.Explanation => @"[original] Tuple element name '{0}' is only allowed at position {1}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8125";
}
