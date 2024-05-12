namespace dotnet_error_lookup.Data.Errors;

public class CS0252 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0252";
    string IErrorOrWarning.Message => @"Possible unintended reference comparison; to get a value comparison, cast the left hand side to type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Possible unintended reference comparison; to get a value comparison, cast the left hand side to type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0252";
}
