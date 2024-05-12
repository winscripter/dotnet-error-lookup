namespace dotnet_error_lookup.Data.Errors;

public class CS2024 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2024";
    string IErrorOrWarning.Message => @"Invalid file section alignment '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Invalid file section alignment '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2024";
}
