namespace dotnet_error_lookup.Data.Errors;

public class CS0164 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0164";
    string IErrorOrWarning.Message => @"This label has not been referenced";
    string IErrorOrWarning.Explanation => @"[original] This label has not been referenced";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0164";
}
