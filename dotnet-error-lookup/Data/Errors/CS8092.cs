namespace dotnet_error_lookup.Data.Errors;

public class CS8092 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8092";
    string IErrorOrWarning.Message => @"Expression or declaration statement expected.";
    string IErrorOrWarning.Explanation => @"[original] Expression or declaration statement expected.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
