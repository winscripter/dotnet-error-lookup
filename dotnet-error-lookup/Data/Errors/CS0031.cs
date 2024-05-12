namespace dotnet_error_lookup.Data.Errors;

public class CS0031 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0031";
    string IErrorOrWarning.Message => @"Constant value '{0}' cannot be converted to a '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Constant value '{0}' cannot be converted to a '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0031";
}
