namespace dotnet_error_lookup.Data.Errors;

public class CS0661 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0661";
    string IErrorOrWarning.Message => @"'{0}' defines operator == or operator != but does not override Object.GetHashCode()";
    string IErrorOrWarning.Explanation => @"[original] '{0}' defines operator == or operator != but does not override Object.GetHashCode()";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0661";
}
