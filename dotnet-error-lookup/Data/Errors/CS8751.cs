namespace dotnet_error_lookup.Data.Errors;

public class CS8751 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8751";
    string IErrorOrWarning.Message => @"Internal error in the C# compiler.";
    string IErrorOrWarning.Explanation => @"[original] Internal error in the C# compiler.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
