namespace dotnet_error_lookup.Data.Errors;

public class CS0543 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0543";
    string IErrorOrWarning.Message => @"'{0}': the enumerator value is too large to fit in its type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': the enumerator value is too large to fit in its type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0543";
}
