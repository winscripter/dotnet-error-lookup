namespace dotnet_error_lookup.Data.Errors;

public class CS0153 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0153";
    string IErrorOrWarning.Message => @"A goto case is only valid inside a switch statement";
    string IErrorOrWarning.Explanation => @"[original] A goto case is only valid inside a switch statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0153";
}
