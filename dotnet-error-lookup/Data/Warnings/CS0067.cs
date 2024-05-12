namespace dotnet_error_lookup.Data.Errors;

public class CS0067 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0067";
    string IErrorOrWarning.Message => @"The event '{0}' is never used";
    string IErrorOrWarning.Explanation => @"[original] The event '{0}' is never used";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0067";
}
