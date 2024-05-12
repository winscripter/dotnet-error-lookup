namespace dotnet_error_lookup.Data.Errors;

public class CS0695 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0695";
    string IErrorOrWarning.Message => @"'{0}' cannot implement both '{1}' and '{2}' because they may unify for some type parameter substitutions";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot implement both '{1}' and '{2}' because they may unify for some type parameter substitutions";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0695";
}
