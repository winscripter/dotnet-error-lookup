namespace dotnet_error_lookup.Data.Errors;

public class CS0159 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0159";
    string IErrorOrWarning.Message => @"No such label '{0}' within the scope of the goto statement";
    string IErrorOrWarning.Explanation => @"[original] No such label '{0}' within the scope of the goto statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0159";
}
