namespace dotnet_error_lookup.Data.Errors;

public class CS1666 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1666";
    string IErrorOrWarning.Message => @"You cannot use fixed size buffers contained in unfixed expressions. Try using the fixed statement.";
    string IErrorOrWarning.Explanation => @"[original] You cannot use fixed size buffers contained in unfixed expressions. Try using the fixed statement.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1666";
}
