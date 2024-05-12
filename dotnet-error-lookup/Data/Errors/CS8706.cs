namespace dotnet_error_lookup.Data.Errors;

public class CS8706 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8706";
    string IErrorOrWarning.Message => @"'{0}' cannot implement interface member '{1}' in type '{2}' because feature '{3}' is not available in C# {4}. Please use language version '{5}' or greater.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot implement interface member '{1}' in type '{2}' because feature '{3}' is not available in C# {4}. Please use language version '{5}' or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
