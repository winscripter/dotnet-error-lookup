namespace dotnet_error_lookup.Data.Errors;

public class CS0646 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0646";
    string IErrorOrWarning.Message => @"Cannot specify the DefaultMember attribute on a type containing an indexer";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify the DefaultMember attribute on a type containing an indexer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0646";
}
