namespace dotnet_error_lookup.Data.Errors;

public class CS0030 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0030";
    string IErrorOrWarning.Message => @"Cannot convert type '{0}' to '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert type '{0}' to '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0030";
}
