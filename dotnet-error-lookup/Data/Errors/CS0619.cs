namespace dotnet_error_lookup.Data.Errors;

public class CS0619 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0619";
    string IErrorOrWarning.Message => @"'{0}' is obsolete: '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is obsolete: '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0619";
}
