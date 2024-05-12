namespace dotnet_error_lookup.Data.Errors;

public class CS0689 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0689";
    string IErrorOrWarning.Message => @"Cannot derive from '{0}' because it is a type parameter";
    string IErrorOrWarning.Explanation => @"[original] Cannot derive from '{0}' because it is a type parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0689";
}
