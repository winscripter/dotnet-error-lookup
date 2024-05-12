namespace dotnet_error_lookup.Data.Errors;

public class CS0620 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0620";
    string IErrorOrWarning.Message => @"Indexers cannot have void type";
    string IErrorOrWarning.Explanation => @"[original] Indexers cannot have void type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0620";
}
