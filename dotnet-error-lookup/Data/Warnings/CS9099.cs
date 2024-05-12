namespace dotnet_error_lookup.Data.Errors;

public class CS9099 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9099";
    string IErrorOrWarning.Message => @"Parameter {0} has default value '{1:10}' in lambda but '{2:10}' in the target delegate type.";
    string IErrorOrWarning.Explanation => @"[original] Parameter {0} has default value '{1:10}' in lambda but '{2:10}' in the target delegate type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
