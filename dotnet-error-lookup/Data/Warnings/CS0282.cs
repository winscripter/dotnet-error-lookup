namespace dotnet_error_lookup.Data.Errors;

public class CS0282 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0282";
    string IErrorOrWarning.Message => @"There is no defined ordering between fields in multiple declarations of partial struct '{0}'. To specify an ordering, all instance fields must be in the same declaration.";
    string IErrorOrWarning.Explanation => @"[original] There is no defined ordering between fields in multiple declarations of partial struct '{0}'. To specify an ordering, all instance fields must be in the same declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0282";
}
