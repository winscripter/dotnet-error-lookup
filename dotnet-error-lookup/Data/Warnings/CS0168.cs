namespace dotnet_error_lookup.Data.Errors;

public class CS0168 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0168";
    string IErrorOrWarning.Message => @"The variable '{0}' is declared but never used";
    string IErrorOrWarning.Explanation => @"[original] The variable '{0}' is declared but never used";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0168";
}
