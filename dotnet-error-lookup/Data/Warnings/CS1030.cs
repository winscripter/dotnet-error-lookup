namespace dotnet_error_lookup.Data.Errors;

public class CS1030 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1030";
    string IErrorOrWarning.Message => @"#warning: '{0}'";
    string IErrorOrWarning.Explanation => @"[original] #warning: '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1030";
}
