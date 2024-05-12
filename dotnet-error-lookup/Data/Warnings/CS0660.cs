namespace dotnet_error_lookup.Data.Errors;

public class CS0660 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0660";
    string IErrorOrWarning.Message => @"'{0}' defines operator == or operator != but does not override Object.Equals(object o)";
    string IErrorOrWarning.Explanation => @"[original] '{0}' defines operator == or operator != but does not override Object.Equals(object o)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0660";
}
