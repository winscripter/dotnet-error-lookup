namespace dotnet_error_lookup.Data.Errors;

public class CS8085 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8085";
    string IErrorOrWarning.Message => @"A 'using static' directive cannot be used to declare an alias";
    string IErrorOrWarning.Explanation => @"[original] A 'using static' directive cannot be used to declare an alias";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
