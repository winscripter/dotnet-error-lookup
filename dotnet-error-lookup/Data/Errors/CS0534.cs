namespace dotnet_error_lookup.Data.Errors;

public class CS0534 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0534";
    string IErrorOrWarning.Message => @"'{0}' does not implement inherited abstract member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement inherited abstract member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0534";
}
