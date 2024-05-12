namespace dotnet_error_lookup.Data.Errors;

public class CS0445 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0445";
    string IErrorOrWarning.Message => @"Cannot modify the result of an unboxing conversion";
    string IErrorOrWarning.Explanation => @"[original] Cannot modify the result of an unboxing conversion";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0445";
}
