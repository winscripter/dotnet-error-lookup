namespace dotnet_error_lookup.Data.Errors;

public class CS1629 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1629";
    string IErrorOrWarning.Message => @"Unsafe code may not appear in iterators";
    string IErrorOrWarning.Explanation => @"[original] Unsafe code may not appear in iterators";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1629";
}
