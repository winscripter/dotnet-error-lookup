namespace dotnet_error_lookup.Data.Errors;

public class CS0642 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0642";
    string IErrorOrWarning.Message => @"Possible mistaken empty statement";
    string IErrorOrWarning.Explanation => @"[original] Possible mistaken empty statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0642";
}
