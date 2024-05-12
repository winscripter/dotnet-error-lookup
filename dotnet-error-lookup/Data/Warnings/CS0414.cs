namespace dotnet_error_lookup.Data.Errors;

public class CS0414 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0414";
    string IErrorOrWarning.Message => @"The field '{0}' is assigned but its value is never used";
    string IErrorOrWarning.Explanation => @"[original] The field '{0}' is assigned but its value is never used";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0414";
}
