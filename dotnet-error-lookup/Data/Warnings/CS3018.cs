namespace dotnet_error_lookup.Data.Errors;

public class CS3018 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3018";
    string IErrorOrWarning.Message => @"'{0}' cannot be marked as CLS-compliant because it is a member of non-CLS-compliant type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be marked as CLS-compliant because it is a member of non-CLS-compliant type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3018";
}
