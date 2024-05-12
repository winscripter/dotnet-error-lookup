namespace dotnet_error_lookup.Data.Errors;

public class CS8388 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8388";
    string IErrorOrWarning.Message => @"An out variable cannot be declared as a ref local";
    string IErrorOrWarning.Explanation => @"[original] An out variable cannot be declared as a ref local";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
