namespace dotnet_error_lookup.Data.Errors;

public class CS0249 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0249";
    string IErrorOrWarning.Message => @"Do not override object.Finalize. Instead, provide a destructor.";
    string IErrorOrWarning.Explanation => @"[original] Do not override object.Finalize. Instead, provide a destructor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0249";
}
