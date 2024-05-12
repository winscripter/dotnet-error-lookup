namespace dotnet_error_lookup.Data.Errors;

public class CS0750 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0750";
    string IErrorOrWarning.Message => @"A partial method cannot have the 'abstract' modifier";
    string IErrorOrWarning.Explanation => @"[original] A partial method cannot have the 'abstract' modifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0750";
}
