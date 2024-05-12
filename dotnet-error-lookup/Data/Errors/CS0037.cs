namespace dotnet_error_lookup.Data.Errors;

public class CS0037 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0037";
    string IErrorOrWarning.Message => @"Cannot convert null to '{0}' because it is a non-nullable value type";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert null to '{0}' because it is a non-nullable value type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0037";
}
