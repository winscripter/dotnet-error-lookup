namespace dotnet_error_lookup.Data.Errors;

public class CS1948 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1948";
    string IErrorOrWarning.Message => @"The range variable '{0}' cannot have the same name as a method type parameter";
    string IErrorOrWarning.Explanation => @"[original] The range variable '{0}' cannot have the same name as a method type parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1948";
}
