namespace dotnet_error_lookup.Data.Errors;

public class CS0009 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Fatal;
    string IErrorOrWarning.Name => @"CS0009";
    string IErrorOrWarning.Message => @"Metadata file '{0}' could not be opened -- {1}";
    string IErrorOrWarning.Explanation => @"[original] Metadata file '{0}' could not be opened -- {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0009";
}
