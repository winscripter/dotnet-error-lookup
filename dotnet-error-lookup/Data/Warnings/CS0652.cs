namespace dotnet_error_lookup.Data.Errors;

public class CS0652 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0652";
    string IErrorOrWarning.Message => @"Comparison to integral constant is useless; the constant is outside the range of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Comparison to integral constant is useless; the constant is outside the range of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0652";
}
