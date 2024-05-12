namespace dotnet_error_lookup.Data.Errors;

public class CS8820 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8820";
    string IErrorOrWarning.Message => @"A static anonymous function cannot contain a reference to '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] A static anonymous function cannot contain a reference to '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
