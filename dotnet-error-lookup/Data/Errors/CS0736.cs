namespace dotnet_error_lookup.Data.Errors;

public class CS0736 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0736";
    string IErrorOrWarning.Message => @"'{0}' does not implement instance interface member '{1}'. '{2}' cannot implement the interface member because it is static.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement instance interface member '{1}'. '{2}' cannot implement the interface member because it is static.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0736";
}
