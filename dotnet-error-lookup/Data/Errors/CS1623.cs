namespace dotnet_error_lookup.Data.Errors;

public class CS1623 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1623";
    string IErrorOrWarning.Message => @"Iterators cannot have ref, in or out parameters";
    string IErrorOrWarning.Explanation => @"[original] Iterators cannot have ref, in or out parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1623";
}
