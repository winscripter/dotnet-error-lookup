namespace dotnet_error_lookup.Data.Errors;

public class CS0121 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0121";
    string IErrorOrWarning.Message => @"The call is ambiguous between the following methods or properties: '{0}' and '{1}'";
    string IErrorOrWarning.Explanation => @"[original] The call is ambiguous between the following methods or properties: '{0}' and '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0121";
}
