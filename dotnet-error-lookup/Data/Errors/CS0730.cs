namespace dotnet_error_lookup.Data.Errors;

public class CS0730 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0730";
    string IErrorOrWarning.Message => @"Cannot forward type '{0}' because it is a nested type of '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot forward type '{0}' because it is a nested type of '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0730";
}
