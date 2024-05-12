namespace dotnet_error_lookup.Data.Errors;

public class CS1574 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1574";
    string IErrorOrWarning.Message => @"XML comment has cref attribute '{0}' that could not be resolved";
    string IErrorOrWarning.Explanation => @"[original] XML comment has cref attribute '{0}' that could not be resolved";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1574";
}
