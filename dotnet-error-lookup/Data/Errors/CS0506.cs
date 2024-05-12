namespace dotnet_error_lookup.Data.Errors;

public class CS0506 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0506";
    string IErrorOrWarning.Message => @"'{0}': cannot override inherited member '{1}' because it is not marked virtual, abstract, or override";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot override inherited member '{1}' because it is not marked virtual, abstract, or override";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0506";
}
