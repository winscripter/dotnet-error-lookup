namespace dotnet_error_lookup.Data.Errors;

public class CS0719 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0719";
    string IErrorOrWarning.Message => @"'{0}': array elements cannot be of static type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': array elements cannot be of static type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0719";
}
