namespace dotnet_error_lookup.Data.Errors;

public class CS0441 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0441";
    string IErrorOrWarning.Message => @"'{0}': a type cannot be both static and sealed";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a type cannot be both static and sealed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0441";
}
