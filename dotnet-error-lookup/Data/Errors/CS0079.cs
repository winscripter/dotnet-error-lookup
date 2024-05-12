namespace dotnet_error_lookup.Data.Errors;

public class CS0079 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0079";
    string IErrorOrWarning.Message => @"The event '{0}' can only appear on the left hand side of += or -=";
    string IErrorOrWarning.Explanation => @"[original] The event '{0}' can only appear on the left hand side of += or -=";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0079";
}
