namespace dotnet_error_lookup.Data.Errors;

public class CS0748 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0748";
    string IErrorOrWarning.Message => @"Inconsistent lambda parameter usage; parameter types must be all explicit or all implicit";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent lambda parameter usage; parameter types must be all explicit or all implicit";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0748";
}
