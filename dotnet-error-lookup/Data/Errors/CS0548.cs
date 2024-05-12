namespace dotnet_error_lookup.Data.Errors;

public class CS0548 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0548";
    string IErrorOrWarning.Message => @"'{0}': property or indexer must have at least one accessor";
    string IErrorOrWarning.Explanation => @"[original] '{0}': property or indexer must have at least one accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0548";
}
