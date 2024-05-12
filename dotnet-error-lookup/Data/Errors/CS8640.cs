namespace dotnet_error_lookup.Data.Errors;

public class CS8640 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8640";
    string IErrorOrWarning.Message => @"Expression tree cannot contain value of ref struct or restricted type '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Expression tree cannot contain value of ref struct or restricted type '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
