namespace dotnet_error_lookup.Data.Errors;

public class CS1635 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1635";
    string IErrorOrWarning.Message => @"Cannot restore warning 'CS{0}' because it was disabled globally";
    string IErrorOrWarning.Explanation => @"[original] Cannot restore warning 'CS{0}' because it was disabled globally";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1635";
}
