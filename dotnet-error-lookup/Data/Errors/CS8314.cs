namespace dotnet_error_lookup.Data.Errors;

public class CS8314 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8314";
    string IErrorOrWarning.Message => @"An expression of type '{0}' cannot be handled by a pattern of type '{1}' in C# {2}. Please use language version {3} or greater.";
    string IErrorOrWarning.Explanation => @"[original] An expression of type '{0}' cannot be handled by a pattern of type '{1}' in C# {2}. Please use language version {3} or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
