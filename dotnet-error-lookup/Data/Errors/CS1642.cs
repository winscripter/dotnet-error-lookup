namespace dotnet_error_lookup.Data.Errors;

public class CS1642 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1642";
    string IErrorOrWarning.Message => @"Fixed size buffer fields may only be members of structs";
    string IErrorOrWarning.Explanation => @"[original] Fixed size buffer fields may only be members of structs";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1642";
}
