namespace dotnet_error_lookup.Data.Errors;

public class CS0641 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0641";
    string IErrorOrWarning.Message => @"Attribute '{0}' is only valid on classes derived from System.Attribute";
    string IErrorOrWarning.Explanation => @"[original] Attribute '{0}' is only valid on classes derived from System.Attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0641";
}
