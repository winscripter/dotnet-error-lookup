namespace dotnet_error_lookup.Data.Errors;

public class CS8421 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8421";
    string IErrorOrWarning.Message => @"A static local function cannot contain a reference to '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] A static local function cannot contain a reference to '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
