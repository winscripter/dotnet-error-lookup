namespace dotnet_error_lookup.Data.Errors;

public class CS8152 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8152";
    string IErrorOrWarning.Message => @"'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not have matching return by reference.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not have matching return by reference.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8152";
}
