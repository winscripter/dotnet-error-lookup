namespace dotnet_error_lookup.Data.Errors;

public class CS0594 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0594";
    string IErrorOrWarning.Message => @"Floating-point constant is outside the range of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Floating-point constant is outside the range of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0594";
}
