namespace dotnet_error_lookup.Data.Errors;

public class CS1044 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1044";
    string IErrorOrWarning.Message => @"Cannot use more than one type in a for, using, fixed, or declaration statement";
    string IErrorOrWarning.Explanation => @"[original] Cannot use more than one type in a for, using, fixed, or declaration statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1044";
}
