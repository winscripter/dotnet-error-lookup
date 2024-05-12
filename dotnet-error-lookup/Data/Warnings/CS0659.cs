namespace dotnet_error_lookup.Data.Errors;

public class CS0659 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0659";
    string IErrorOrWarning.Message => @"'{0}' overrides Object.Equals(object o) but does not override Object.GetHashCode()";
    string IErrorOrWarning.Explanation => @"[original] '{0}' overrides Object.Equals(object o) but does not override Object.GetHashCode()";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0659";
}
