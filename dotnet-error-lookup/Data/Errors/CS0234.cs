namespace dotnet_error_lookup.Data.Errors;

public class CS0234 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0234";
    string IErrorOrWarning.Message => @"The type or namespace name '{0}' does not exist in the namespace '{1}' (are you missing an assembly reference?)";
    string IErrorOrWarning.Explanation => @"[original] The type or namespace name '{0}' does not exist in the namespace '{1}' (are you missing an assembly reference?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0234";
}
