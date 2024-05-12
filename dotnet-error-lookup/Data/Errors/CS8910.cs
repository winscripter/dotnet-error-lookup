namespace dotnet_error_lookup.Data.Errors;

public class CS8910 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8910";
    string IErrorOrWarning.Message => @"The primary constructor conflicts with the synthesized copy constructor.";
    string IErrorOrWarning.Explanation => @"[original] The primary constructor conflicts with the synthesized copy constructor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
