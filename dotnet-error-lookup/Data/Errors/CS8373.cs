namespace dotnet_error_lookup.Data.Errors;

public class CS8373 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8373";
    string IErrorOrWarning.Message => @"The left-hand side of a ref assignment must be a ref variable.";
    string IErrorOrWarning.Explanation => @"[original] The left-hand side of a ref assignment must be a ref variable.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8373";
}
