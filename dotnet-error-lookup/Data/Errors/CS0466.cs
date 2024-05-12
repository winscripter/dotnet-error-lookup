namespace dotnet_error_lookup.Data.Errors;

public class CS0466 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0466";
    string IErrorOrWarning.Message => @"'{0}' should not have a params parameter since '{1}' does not";
    string IErrorOrWarning.Explanation => @"[original] '{0}' should not have a params parameter since '{1}' does not";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0466";
}
