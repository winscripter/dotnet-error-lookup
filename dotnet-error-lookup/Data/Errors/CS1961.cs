namespace dotnet_error_lookup.Data.Errors;

public class CS1961 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1961";
    string IErrorOrWarning.Message => @"Invalid variance: The type parameter '{1}' must be {3} valid on '{0}'. '{1}' is {2}.";
    string IErrorOrWarning.Explanation => @"[original] Invalid variance: The type parameter '{1}' must be {3} valid on '{0}'. '{1}' is {2}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
