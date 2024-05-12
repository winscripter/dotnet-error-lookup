namespace dotnet_error_lookup.Data.Errors;

public class CS0742 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0742";
    string IErrorOrWarning.Message => @"A query body must end with a select clause or a group clause";
    string IErrorOrWarning.Explanation => @"[original] A query body must end with a select clause or a group clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0742";
}
