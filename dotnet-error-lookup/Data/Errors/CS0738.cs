namespace dotnet_error_lookup.Data.Errors;

public class CS0738 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0738";
    string IErrorOrWarning.Message => @"'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not have the matching return type of '{3}'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not have the matching return type of '{3}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0738";
}
