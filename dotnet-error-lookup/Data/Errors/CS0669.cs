namespace dotnet_error_lookup.Data.Errors;

public class CS0669 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0669";
    string IErrorOrWarning.Message => @"A class with the ComImport attribute cannot have a user-defined constructor";
    string IErrorOrWarning.Explanation => @"[original] A class with the ComImport attribute cannot have a user-defined constructor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0669";
}
