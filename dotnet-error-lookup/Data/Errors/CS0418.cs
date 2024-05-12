namespace dotnet_error_lookup.Data.Errors;

public class CS0418 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0418";
    string IErrorOrWarning.Message => @"'{0}': an abstract type cannot be sealed or static";
    string IErrorOrWarning.Explanation => @"[original] '{0}': an abstract type cannot be sealed or static";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0418";
}
