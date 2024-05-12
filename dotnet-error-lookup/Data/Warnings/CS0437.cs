namespace dotnet_error_lookup.Data.Errors;

public class CS0437 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0437";
    string IErrorOrWarning.Message => @"The type '{1}' in '{0}' conflicts with the imported namespace '{3}' in '{2}'. Using the type defined in '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] The type '{1}' in '{0}' conflicts with the imported namespace '{3}' in '{2}'. Using the type defined in '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0437";
}
