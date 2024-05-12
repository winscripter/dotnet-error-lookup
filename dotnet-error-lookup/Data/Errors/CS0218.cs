namespace dotnet_error_lookup.Data.Errors;

public class CS0218 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0218";
    string IErrorOrWarning.Message => @"In order for '{0}' to be applicable as a short circuit operator, its declaring type '{1}' must define operator true and operator false";
    string IErrorOrWarning.Explanation => @"[original] In order for '{0}' to be applicable as a short circuit operator, its declaring type '{1}' must define operator true and operator false";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0218";
}
