namespace dotnet_error_lookup.Data.Errors;

public class CS0199 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0199";
    string IErrorOrWarning.Message => @"A static readonly field cannot be used as a ref or out value (except in a static constructor)";
    string IErrorOrWarning.Explanation => @"[original] A static readonly field cannot be used as a ref or out value (except in a static constructor)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0199";
}
