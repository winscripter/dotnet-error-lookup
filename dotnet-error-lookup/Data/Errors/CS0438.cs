namespace dotnet_error_lookup.Data.Errors;

public class CS0438 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0438";
    string IErrorOrWarning.Message => @"The type '{1}' in '{0}' conflicts with the namespace '{3}' in '{2}'";
    string IErrorOrWarning.Explanation => @"[original] The type '{1}' in '{0}' conflicts with the namespace '{3}' in '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0438";
}
