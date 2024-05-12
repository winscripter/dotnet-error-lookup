namespace dotnet_error_lookup.Data.Errors;

public class CS0473 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0473";
    string IErrorOrWarning.Message => @"Explicit interface implementation '{0}' matches more than one interface member. Which interface member is actually chosen is implementation-dependent. Consider using a non-explicit implementation instead.";
    string IErrorOrWarning.Explanation => @"[original] Explicit interface implementation '{0}' matches more than one interface member. Which interface member is actually chosen is implementation-dependent. Consider using a non-explicit implementation instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0473";
}
