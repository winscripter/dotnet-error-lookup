namespace dotnet_error_lookup.Data.Errors;

public class CS0653 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0653";
    string IErrorOrWarning.Message => @"Cannot apply attribute class '{0}' because it is abstract";
    string IErrorOrWarning.Explanation => @"[original] Cannot apply attribute class '{0}' because it is abstract";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0653";
}
