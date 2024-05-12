namespace dotnet_error_lookup.Data.Errors;

public class CS4014 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS4014";
    string IErrorOrWarning.Message => @"Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'await' operator to the result of the call.";
    string IErrorOrWarning.Explanation => @"[original] Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'await' operator to the result of the call.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4014";
}
