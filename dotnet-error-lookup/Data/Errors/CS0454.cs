namespace dotnet_error_lookup.Data.Errors;

public class CS0454 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0454";
    string IErrorOrWarning.Message => @"Circular constraint dependency involving '{0}' and '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Circular constraint dependency involving '{0}' and '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0454";
}
