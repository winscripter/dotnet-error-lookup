namespace dotnet_error_lookup.Data.Errors;

public class CS8084 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8084";
    string IErrorOrWarning.Message => @"Type parameters are not allowed on a method group as an argument to 'nameof'.";
    string IErrorOrWarning.Explanation => @"[original] Type parameters are not allowed on a method group as an argument to 'nameof'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
