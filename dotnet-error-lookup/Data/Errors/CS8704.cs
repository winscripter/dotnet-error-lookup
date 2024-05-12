namespace dotnet_error_lookup.Data.Errors;

public class CS8704 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8704";
    string IErrorOrWarning.Message => @"'{0}' does not implement interface member '{1}'. '{2}' cannot implicitly implement a non-public member in C# {3}. Please use language version '{4}' or greater.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement interface member '{1}'. '{2}' cannot implicitly implement a non-public member in C# {3}. Please use language version '{4}' or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
