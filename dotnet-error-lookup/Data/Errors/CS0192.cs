namespace dotnet_error_lookup.Data.Errors;

public class CS0192 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0192";
    string IErrorOrWarning.Message => @"A readonly field cannot be used as a ref or out value (except in a constructor)";
    string IErrorOrWarning.Explanation => @"[original] A readonly field cannot be used as a ref or out value (except in a constructor)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0192";
}
