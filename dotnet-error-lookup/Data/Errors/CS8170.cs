namespace dotnet_error_lookup.Data.Errors;

public class CS8170 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8170";
    string IErrorOrWarning.Message => @"Struct members cannot return 'this' or other instance members by reference";
    string IErrorOrWarning.Explanation => @"[original] Struct members cannot return 'this' or other instance members by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8170";
}
