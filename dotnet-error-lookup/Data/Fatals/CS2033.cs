namespace dotnet_error_lookup.Data.Errors;

public class CS2033 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Fatal;
    string IErrorOrWarning.Name => @"CS2033";
    string IErrorOrWarning.Message => @"Cannot create short filename '{0}' when a long filename with the same short filename already exists";
    string IErrorOrWarning.Explanation => @"[original] Cannot create short filename '{0}' when a long filename with the same short filename already exists";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2033";
}
