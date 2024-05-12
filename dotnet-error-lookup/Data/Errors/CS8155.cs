namespace dotnet_error_lookup.Data.Errors;

public class CS8155 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8155";
    string IErrorOrWarning.Message => @"Lambda expressions that return by reference cannot be converted to expression trees";
    string IErrorOrWarning.Explanation => @"[original] Lambda expressions that return by reference cannot be converted to expression trees";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8155";
}
