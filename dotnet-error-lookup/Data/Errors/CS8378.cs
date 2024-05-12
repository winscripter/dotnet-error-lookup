namespace dotnet_error_lookup.Data.Errors;

public class CS8378 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8378";
    string IErrorOrWarning.Message => @"\_\_arglist cannot have an argument passed by 'in' or 'out'";
    string IErrorOrWarning.Explanation => @"[original] \_\_arglist cannot have an argument passed by 'in' or 'out'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
