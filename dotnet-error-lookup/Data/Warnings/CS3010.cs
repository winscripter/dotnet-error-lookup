namespace dotnet_error_lookup.Data.Errors;

public class CS3010 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3010";
    string IErrorOrWarning.Message => @"'{0}': CLS-compliant interfaces must have only CLS-compliant members";
    string IErrorOrWarning.Explanation => @"[original] '{0}': CLS-compliant interfaces must have only CLS-compliant members";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3010";
}
