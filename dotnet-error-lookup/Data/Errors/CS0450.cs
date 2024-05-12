namespace dotnet_error_lookup.Data.Errors;

public class CS0450 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0450";
    string IErrorOrWarning.Message => @"'{0}': cannot specify both a constraint class and the 'class' or 'struct' constraint";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot specify both a constraint class and the 'class' or 'struct' constraint";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0450";
}
