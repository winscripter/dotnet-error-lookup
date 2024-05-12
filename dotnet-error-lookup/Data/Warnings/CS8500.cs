namespace dotnet_error_lookup.Data.Errors;

public class CS8500 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8500";
    string IErrorOrWarning.Message => @"This takes the address of, gets the size of, or declares a pointer to a managed type ('{0}')";
    string IErrorOrWarning.Explanation => @"[original] This takes the address of, gets the size of, or declares a pointer to a managed type ('{0}')";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
