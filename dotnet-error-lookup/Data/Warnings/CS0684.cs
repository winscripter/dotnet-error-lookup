namespace dotnet_error_lookup.Data.Errors;

public class CS0684 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0684";
    string IErrorOrWarning.Message => @"'{0}' interface marked with 'CoClassAttribute' not marked with 'ComImportAttribute'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' interface marked with 'CoClassAttribute' not marked with 'ComImportAttribute'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0684";
}
