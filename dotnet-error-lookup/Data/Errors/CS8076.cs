namespace dotnet_error_lookup.Data.Errors;

public class CS8076 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8076";
    string IErrorOrWarning.Message => @"Missing close delimiter '}' for interpolated expression started with '{'.";
    string IErrorOrWarning.Explanation => @"[original] Missing close delimiter '}' for interpolated expression started with '{'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
