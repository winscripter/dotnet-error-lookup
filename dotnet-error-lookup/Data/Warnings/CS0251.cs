namespace dotnet_error_lookup.Data.Errors;

public class CS0251 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0251";
    string IErrorOrWarning.Message => @"Indexing an array with a negative index (array indices always start at zero)";
    string IErrorOrWarning.Explanation => @"[original] Indexing an array with a negative index (array indices always start at zero)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0251";
}
