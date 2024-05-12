namespace dotnet_error_lookup.Data.Errors;

public class CS0428 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0428";
    string IErrorOrWarning.Message => @"Cannot convert method group '{0}' to non-delegate type '{1}'. Did you intend to invoke the method?";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert method group '{0}' to non-delegate type '{1}'. Did you intend to invoke the method?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0428";
}
