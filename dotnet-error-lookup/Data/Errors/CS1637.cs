namespace dotnet_error_lookup.Data.Errors;

public class CS1637 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1637";
    string IErrorOrWarning.Message => @"Iterators cannot have unsafe parameters or yield types";
    string IErrorOrWarning.Explanation => @"[original] Iterators cannot have unsafe parameters or yield types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1637";
}
