namespace dotnet_error_lookup.Data.Errors;

public class CS1715 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1715";
    string IErrorOrWarning.Message => @"'{0}': type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1715";
}
