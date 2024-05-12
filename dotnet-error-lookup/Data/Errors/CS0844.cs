namespace dotnet_error_lookup.Data.Errors;

public class CS0844 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0844";
    string IErrorOrWarning.Message => @"Cannot use local variable '{0}' before it is declared. The declaration of the local variable hides the field '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use local variable '{0}' before it is declared. The declaration of the local variable hides the field '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0844";
}
