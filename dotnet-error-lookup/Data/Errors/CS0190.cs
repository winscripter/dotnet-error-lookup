namespace dotnet_error_lookup.Data.Errors;

public class CS0190 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0190";
    string IErrorOrWarning.Message => @"The \_\_arglist construct is valid only within a variable argument method";
    string IErrorOrWarning.Explanation => @"[original] The \_\_arglist construct is valid only within a variable argument method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
