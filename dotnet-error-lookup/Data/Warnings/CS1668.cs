namespace dotnet_error_lookup.Data.Errors;

public class CS1668 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1668";
    string IErrorOrWarning.Message => @"Invalid search path '{0}' specified in '{1}' -- '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Invalid search path '{0}' specified in '{1}' -- '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1668";
}
