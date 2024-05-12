namespace dotnet_error_lookup.Data.Errors;

public class CS1728 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1728";
    string IErrorOrWarning.Message => @"Cannot bind delegate to '{0}' because it is a member of 'System.Nullable\<T\>'";
    string IErrorOrWarning.Explanation => @"[original] Cannot bind delegate to '{0}' because it is a member of 'System.Nullable\<T\>'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1728";
}
