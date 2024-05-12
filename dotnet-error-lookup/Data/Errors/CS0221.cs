namespace dotnet_error_lookup.Data.Errors;

public class CS0221 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0221";
    string IErrorOrWarning.Message => @"Constant value '{0}' cannot be converted to a '{1}' (use 'unchecked' syntax to override)";
    string IErrorOrWarning.Explanation => @"[original] Constant value '{0}' cannot be converted to a '{1}' (use 'unchecked' syntax to override)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0221";
}
