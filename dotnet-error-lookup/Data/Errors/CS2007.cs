namespace dotnet_error_lookup.Data.Errors;

public class CS2007 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2007";
    string IErrorOrWarning.Message => @"Unrecognized option: '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Unrecognized option: '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2007";
}
