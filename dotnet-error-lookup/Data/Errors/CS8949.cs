namespace dotnet_error_lookup.Data.Errors;

public class CS8949 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8949";
    string IErrorOrWarning.Message => @"The InterpolatedStringHandlerArgumentAttribute applied to parameter '{0}' is malformed and cannot be interpreted. Construct an instance of '{1}' manually.";
    string IErrorOrWarning.Explanation => @"[original] The InterpolatedStringHandlerArgumentAttribute applied to parameter '{0}' is malformed and cannot be interpreted. Construct an instance of '{1}' manually.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
