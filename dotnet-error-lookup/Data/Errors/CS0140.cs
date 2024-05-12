namespace dotnet_error_lookup.Data.Errors;

public class CS0140 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0140";
    string IErrorOrWarning.Message => @"The label '{0}' is a duplicate";
    string IErrorOrWarning.Explanation => @"[original] The label '{0}' is a duplicate";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0140";
}
