namespace dotnet_error_lookup.Data.Errors;

public class CS0739 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0739";
    string IErrorOrWarning.Message => @"'{0}' duplicate TypeForwardedToAttribute";
    string IErrorOrWarning.Explanation => @"[original] '{0}' duplicate TypeForwardedToAttribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0739";
}
