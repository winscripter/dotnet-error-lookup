namespace dotnet_error_lookup.Data.Errors;

public class CS9100 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9100";
    string IErrorOrWarning.Message => @"Parameter {0} has params modifier in lambda but not in target delegate type.";
    string IErrorOrWarning.Explanation => @"[original] Parameter {0} has params modifier in lambda but not in target delegate type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
