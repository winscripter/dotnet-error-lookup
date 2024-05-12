namespace dotnet_error_lookup.Data.Errors;

public class CS0693 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0693";
    string IErrorOrWarning.Message => @"Type parameter '{0}' has the same name as the type parameter from outer type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Type parameter '{0}' has the same name as the type parameter from outer type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0693";
}
