namespace dotnet_error_lookup.Data.Errors;

public class CS1570 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1570";
    string IErrorOrWarning.Message => @"XML comment has badly formed XML -- '{0}'";
    string IErrorOrWarning.Explanation => @"[original] XML comment has badly formed XML -- '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1570";
}
