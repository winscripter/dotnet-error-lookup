namespace dotnet_error_lookup.Data.Errors;

public class CS8137 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8137";
    string IErrorOrWarning.Message => @"Cannot define a class or member that utilizes tuples because the compiler required type '{0}' cannot be found. Are you missing a reference?";
    string IErrorOrWarning.Explanation => @"[original] Cannot define a class or member that utilizes tuples because the compiler required type '{0}' cannot be found. Are you missing a reference?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
