namespace dotnet_error_lookup.Data.Errors;

public class CS0756 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0756";
    string IErrorOrWarning.Message => @"A partial method may not have multiple defining declarations";
    string IErrorOrWarning.Explanation => @"[original] A partial method may not have multiple defining declarations";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0756";
}
