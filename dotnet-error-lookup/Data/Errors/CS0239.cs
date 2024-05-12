namespace dotnet_error_lookup.Data.Errors;

public class CS0239 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0239";
    string IErrorOrWarning.Message => @"'{0}': cannot override inherited member '{1}' because it is sealed";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot override inherited member '{1}' because it is sealed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0239";
}
