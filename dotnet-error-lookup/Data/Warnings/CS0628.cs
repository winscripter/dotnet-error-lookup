namespace dotnet_error_lookup.Data.Errors;

public class CS0628 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0628";
    string IErrorOrWarning.Message => @"'{0}': new protected member declared in sealed type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': new protected member declared in sealed type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0628";
}
