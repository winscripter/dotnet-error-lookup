namespace dotnet_error_lookup.Data.Errors;

public class CS3011 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3011";
    string IErrorOrWarning.Message => @"'{0}': only CLS-compliant members can be abstract";
    string IErrorOrWarning.Explanation => @"[original] '{0}': only CLS-compliant members can be abstract";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3011";
}
