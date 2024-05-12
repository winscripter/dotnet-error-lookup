namespace dotnet_error_lookup.Data.Errors;

public class CS8627 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8627";
    string IErrorOrWarning.Message => @"A nullable type parameter must be known to be a value type or non-nullable reference type unless language version '{0}' or greater is used. Consider changing the language version or adding a 'class', 'struct', or type constraint.";
    string IErrorOrWarning.Explanation => @"[original] A nullable type parameter must be known to be a value type or non-nullable reference type unless language version '{0}' or greater is used. Consider changing the language version or adding a 'class', 'struct', or type constraint.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
