namespace dotnet_error_lookup.Data.Errors;

public class CS8821 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8821";
    string IErrorOrWarning.Message => @"A static anonymous function cannot contain a reference to 'this' or 'base'.";
    string IErrorOrWarning.Explanation => @"[original] A static anonymous function cannot contain a reference to 'this' or 'base'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
