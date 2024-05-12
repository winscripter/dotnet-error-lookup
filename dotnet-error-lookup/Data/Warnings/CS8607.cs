namespace dotnet_error_lookup.Data.Errors;

public class CS8607 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8607";
    string IErrorOrWarning.Message => @"A possible null value may not be used for a type marked with [NotNull] or [DisallowNull]";
    string IErrorOrWarning.Explanation => @"[original] A possible null value may not be used for a type marked with [NotNull] or [DisallowNull]";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
