namespace dotnet_error_lookup.Data.Errors;

public class CS0685 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0685";
    string IErrorOrWarning.Message => @"Conditional member '{0}' cannot have an out parameter";
    string IErrorOrWarning.Explanation => @"[original] Conditional member '{0}' cannot have an out parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0685";
}
