namespace dotnet_error_lookup.Data.Errors;

public class CS0527 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0527";
    string IErrorOrWarning.Message => @"Type '{0}' in interface list is not an interface";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' in interface list is not an interface";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0527";
}
