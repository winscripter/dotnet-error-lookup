namespace dotnet_error_lookup.Data.Errors;

public class CS1611 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1611";
    string IErrorOrWarning.Message => @"The params parameter cannot be declared as {0}";
    string IErrorOrWarning.Explanation => @"[original] The params parameter cannot be declared as {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1611";
}
