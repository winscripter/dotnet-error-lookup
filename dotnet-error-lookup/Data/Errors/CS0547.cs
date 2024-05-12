namespace dotnet_error_lookup.Data.Errors;

public class CS0547 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0547";
    string IErrorOrWarning.Message => @"'{0}': property or indexer cannot have void type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': property or indexer cannot have void type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0547";
}
