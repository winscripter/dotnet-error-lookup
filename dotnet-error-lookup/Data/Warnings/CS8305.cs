namespace dotnet_error_lookup.Data.Errors;

public class CS8305 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8305";
    string IErrorOrWarning.Message => @"'{0}' is for evaluation purposes only and is subject to change or removal in future updates.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is for evaluation purposes only and is subject to change or removal in future updates.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
