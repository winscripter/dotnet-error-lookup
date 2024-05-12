namespace dotnet_error_lookup.Data.Errors;

public class CS0762 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0762";
    string IErrorOrWarning.Message => @"Cannot create delegate from method '{0}' because it is a partial method without an implementing declaration";
    string IErrorOrWarning.Explanation => @"[original] Cannot create delegate from method '{0}' because it is a partial method without an implementing declaration";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0762";
}
