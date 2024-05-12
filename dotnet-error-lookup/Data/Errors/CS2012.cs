namespace dotnet_error_lookup.Data.Errors;

public class CS2012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2012";
    string IErrorOrWarning.Message => @"Cannot open '{0}' for writing -- '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot open '{0}' for writing -- '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2012";
}
