namespace dotnet_error_lookup.Data.Errors;

public class CS0266 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0266";
    string IErrorOrWarning.Message => @"Cannot implicitly convert type '{0}' to '{1}'. An explicit conversion exists (are you missing a cast?)";
    string IErrorOrWarning.Explanation => @"[original] Cannot implicitly convert type '{0}' to '{1}'. An explicit conversion exists (are you missing a cast?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0266";
}
