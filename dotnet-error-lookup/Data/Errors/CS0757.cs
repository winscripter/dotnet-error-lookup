namespace dotnet_error_lookup.Data.Errors;

public class CS0757 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0757";
    string IErrorOrWarning.Message => @"A partial method may not have multiple implementing declarations";
    string IErrorOrWarning.Explanation => @"[original] A partial method may not have multiple implementing declarations";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0757";
}
