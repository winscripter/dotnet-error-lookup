namespace dotnet_error_lookup.Data.Errors;

public class CS8763 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8763";
    string IErrorOrWarning.Message => @"A method marked [DoesNotReturn] should not return.";
    string IErrorOrWarning.Explanation => @"[original] A method marked [DoesNotReturn] should not return.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
