namespace dotnet_error_lookup.Data.Errors;

public class CS0102 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0102";
    string IErrorOrWarning.Message => @"The type '{0}' already contains a definition for '{1}'";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' already contains a definition for '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0102";
}
