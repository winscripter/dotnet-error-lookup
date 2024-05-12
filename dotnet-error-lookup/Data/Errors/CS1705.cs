namespace dotnet_error_lookup.Data.Errors;

public class CS1705 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1705";
    string IErrorOrWarning.Message => @"Assembly '{0}' with identity '{1}' uses '{2}' which has a higher version than referenced assembly '{3}' with identity '{4}'";
    string IErrorOrWarning.Explanation => @"[original] Assembly '{0}' with identity '{1}' uses '{2}' which has a higher version than referenced assembly '{3}' with identity '{4}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1705";
}
