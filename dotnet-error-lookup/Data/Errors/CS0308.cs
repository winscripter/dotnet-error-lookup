namespace dotnet_error_lookup.Data.Errors;

public class CS0308 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0308";
    string IErrorOrWarning.Message => @"The non-generic {1} '{0}' cannot be used with type arguments";
    string IErrorOrWarning.Explanation => @"[original] The non-generic {1} '{0}' cannot be used with type arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0308";
}
