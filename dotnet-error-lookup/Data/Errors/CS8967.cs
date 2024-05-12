namespace dotnet_error_lookup.Data.Errors;

public class CS8967 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8967";
    string IErrorOrWarning.Message => @"Newlines inside a non-verbatim interpolated string are not supported in C# {0}. Please use language version {1} or greater.";
    string IErrorOrWarning.Explanation => @"[original] Newlines inside a non-verbatim interpolated string are not supported in C# {0}. Please use language version {1} or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
