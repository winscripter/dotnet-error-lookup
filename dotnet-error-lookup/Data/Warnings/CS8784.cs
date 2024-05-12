namespace dotnet_error_lookup.Data.Errors;

public class CS8784 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8784";
    string IErrorOrWarning.Message => @"Generator '{0}' failed to initialize. It will not contribute to the output and compilation errors may occur as a result. Exception was of type '{1}' with message '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Generator '{0}' failed to initialize. It will not contribute to the output and compilation errors may occur as a result. Exception was of type '{1}' with message '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
