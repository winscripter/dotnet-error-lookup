namespace dotnet_error_lookup.Data.Errors;

public class CS0197 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0197";
    string IErrorOrWarning.Message => @"Using '{0}' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class";
    string IErrorOrWarning.Explanation => @"[original] Using '{0}' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0197";
}
