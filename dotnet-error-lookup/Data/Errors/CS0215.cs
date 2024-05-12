namespace dotnet_error_lookup.Data.Errors;

public class CS0215 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0215";
    string IErrorOrWarning.Message => @"The return type of operator True or False must be bool";
    string IErrorOrWarning.Explanation => @"[original] The return type of operator True or False must be bool";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0215";
}
