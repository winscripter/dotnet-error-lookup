namespace dotnet_error_lookup.Data.Errors;

public class CS0021 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0021";
    string IErrorOrWarning.Message => @"Cannot apply indexing with [] to an expression of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot apply indexing with [] to an expression of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0021";
}
