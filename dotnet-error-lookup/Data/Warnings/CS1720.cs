namespace dotnet_error_lookup.Data.Errors;

public class CS1720 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1720";
    string IErrorOrWarning.Message => @"Expression will always cause a System.NullReferenceException because the default value of '{0}' is null";
    string IErrorOrWarning.Explanation => @"[original] Expression will always cause a System.NullReferenceException because the default value of '{0}' is null";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1720";
}
