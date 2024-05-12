namespace dotnet_error_lookup.Data.Errors;

public class CS0435 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0435";
    string IErrorOrWarning.Message => @"The namespace '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the namespace defined in '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] The namespace '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the namespace defined in '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0435";
}
