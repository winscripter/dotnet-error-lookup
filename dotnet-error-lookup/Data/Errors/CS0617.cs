namespace dotnet_error_lookup.Data.Errors;

public class CS0617 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0617";
    string IErrorOrWarning.Message => @"'{0}' is not a valid named attribute argument. Named attribute arguments must be fields which are not readonly, static, or const, or read-write properties which are public and not static.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a valid named attribute argument. Named attribute arguments must be fields which are not readonly, static, or const, or read-write properties which are public and not static.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0617";
}
