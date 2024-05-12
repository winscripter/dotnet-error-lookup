namespace dotnet_error_lookup.Data.Errors;

public class CS8355 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8355";
    string IErrorOrWarning.Message => @"An in parameter cannot have the Out attribute.";
    string IErrorOrWarning.Explanation => @"[original] An in parameter cannot have the Out attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
