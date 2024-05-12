namespace dotnet_error_lookup.Data.Errors;

public class CS0415 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0415";
    string IErrorOrWarning.Message => @"The '{0}' attribute is valid only on an indexer that is not an explicit interface member declaration";
    string IErrorOrWarning.Explanation => @"[original] The '{0}' attribute is valid only on an indexer that is not an explicit interface member declaration";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0415";
}
