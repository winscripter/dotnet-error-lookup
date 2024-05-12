namespace dotnet_error_lookup.Data.Errors;

public class CS0143 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0143";
    string IErrorOrWarning.Message => @"The type '{0}' has no constructors defined";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' has no constructors defined";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0143";
}
