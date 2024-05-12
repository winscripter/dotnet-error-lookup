namespace dotnet_error_lookup.Data.Errors;

public class CS1109 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1109";
    string IErrorOrWarning.Message => @"Extension methods must be defined in a top level static class; {0} is a nested class";
    string IErrorOrWarning.Explanation => @"[original] Extension methods must be defined in a top level static class; {0} is a nested class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1109";
}
