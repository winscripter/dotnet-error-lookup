namespace dotnet_error_lookup.Data.Errors;

public class CS3014 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3014";
    string IErrorOrWarning.Message => @"'{0}' cannot be marked as CLS-compliant because the assembly does not have a CLSCompliant attribute";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be marked as CLS-compliant because the assembly does not have a CLSCompliant attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3014";
}
