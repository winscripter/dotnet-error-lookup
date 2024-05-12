namespace dotnet_error_lookup.Data.Errors;

public class CS0648 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0648";
    string IErrorOrWarning.Message => @"'{0}' is a type not supported by the language";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is a type not supported by the language";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0648";
}
