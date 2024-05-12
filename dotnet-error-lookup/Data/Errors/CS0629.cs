namespace dotnet_error_lookup.Data.Errors;

public class CS0629 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0629";
    string IErrorOrWarning.Message => @"Conditional member '{0}' cannot implement interface member '{1}' in type '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Conditional member '{0}' cannot implement interface member '{1}' in type '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0629";
}
