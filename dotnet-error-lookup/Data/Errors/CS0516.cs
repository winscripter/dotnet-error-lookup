namespace dotnet_error_lookup.Data.Errors;

public class CS0516 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0516";
    string IErrorOrWarning.Message => @"Constructor '{0}' cannot call itself";
    string IErrorOrWarning.Explanation => @"[original] Constructor '{0}' cannot call itself";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0516";
}
