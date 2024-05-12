namespace dotnet_error_lookup.Data.Errors;

public class CS0265 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0265";
    string IErrorOrWarning.Message => @"Partial declarations of '{0}' have inconsistent constraints for type parameter '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Partial declarations of '{0}' have inconsistent constraints for type parameter '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0265";
}
