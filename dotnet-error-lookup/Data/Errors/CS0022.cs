namespace dotnet_error_lookup.Data.Errors;

public class CS0022 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0022";
    string IErrorOrWarning.Message => @"Wrong number of indices inside []; expected {0}";
    string IErrorOrWarning.Explanation => @"[original] Wrong number of indices inside []; expected {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0022";
}
