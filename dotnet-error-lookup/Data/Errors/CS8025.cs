namespace dotnet_error_lookup.Data.Errors;

public class CS8025 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8025";
    string IErrorOrWarning.Message => @"Feature '{0}' is not available in C# 4. Please use language version {1} or greater.";
    string IErrorOrWarning.Explanation => @"[original] Feature '{0}' is not available in C# 4. Please use language version {1} or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
