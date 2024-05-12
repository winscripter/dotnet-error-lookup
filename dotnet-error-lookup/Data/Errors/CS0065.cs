namespace dotnet_error_lookup.Data.Errors;

public class CS0065 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0065";
    string IErrorOrWarning.Message => @"'{0}': event property must have both add and remove accessors";
    string IErrorOrWarning.Explanation => @"[original] '{0}': event property must have both add and remove accessors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0065";
}
