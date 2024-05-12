namespace dotnet_error_lookup.Data.Errors;

public class CS0675 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0675";
    string IErrorOrWarning.Message => @"Bitwise-or operator used on a sign-extended operand; consider casting to a smaller unsigned type first";
    string IErrorOrWarning.Explanation => @"[original] Bitwise-or operator used on a sign-extended operand; consider casting to a smaller unsigned type first";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0675";
}
