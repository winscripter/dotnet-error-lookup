namespace dotnet_error_lookup.Data.Errors;

public class CS0101 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0101";
    string IErrorOrWarning.Message => @"The namespace '{1}' already contains a definition for '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The namespace '{1}' already contains a definition for '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0101";
}
