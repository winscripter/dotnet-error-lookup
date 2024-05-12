namespace dotnet_error_lookup.Data.Errors;

public class CS8868 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8868";
    string IErrorOrWarning.Message => @"A copy constructor in a record must call a copy constructor of the base, or a parameterless object constructor if the record inherits from object.";
    string IErrorOrWarning.Explanation => @"[original] A copy constructor in a record must call a copy constructor of the base, or a parameterless object constructor if the record inherits from object.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
