namespace dotnet_error_lookup.Data.Errors;

public class CS0268 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0268";
    string IErrorOrWarning.Message => @"Imported type '{0}' is invalid. It contains a circular base type dependency.";
    string IErrorOrWarning.Explanation => @"[original] Imported type '{0}' is invalid. It contains a circular base type dependency.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0268";
}
