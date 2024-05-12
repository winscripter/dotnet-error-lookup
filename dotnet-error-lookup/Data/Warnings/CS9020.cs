namespace dotnet_error_lookup.Data.Errors;

public class CS9020 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9020";
    string IErrorOrWarning.Message => @"The 'this' object is read before all of its fields have been assigned, causing preceding implicit assignments of 'default' to non-explicitly assigned fields.";
    string IErrorOrWarning.Explanation => @"[original] The 'this' object is read before all of its fields have been assigned, causing preceding implicit assignments of 'default' to non-explicitly assigned fields.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
