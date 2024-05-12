namespace dotnet_error_lookup.Data.Errors;

public class CS1586 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1586";
    string IErrorOrWarning.Message => @"Array creation must have array size or array initializer";
    string IErrorOrWarning.Explanation => @"[original] Array creation must have array size or array initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1586";
}
