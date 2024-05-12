namespace dotnet_error_lookup.Data.Errors;

public class CS8904 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8904";
    string IErrorOrWarning.Message => @"Invalid variance: The type parameter '{1}' must be {3} valid on '{0}' unless language version '{4}' or greater is used. '{1}' is {2}.";
    string IErrorOrWarning.Explanation => @"[original] Invalid variance: The type parameter '{1}' must be {3} valid on '{0}' unless language version '{4}' or greater is used. '{1}' is {2}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
