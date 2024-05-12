namespace dotnet_error_lookup.Data.Errors;

public class CS0765 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0765";
    string IErrorOrWarning.Message => @"Partial methods with only a defining declaration or removed conditional methods cannot be used in expression trees";
    string IErrorOrWarning.Explanation => @"[original] Partial methods with only a defining declaration or removed conditional methods cannot be used in expression trees";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0765";
}
