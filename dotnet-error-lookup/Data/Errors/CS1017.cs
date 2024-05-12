namespace dotnet_error_lookup.Data.Errors;

public class CS1017 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1017";
    string IErrorOrWarning.Message => @"Catch clauses cannot follow the general catch clause of a try statement";
    string IErrorOrWarning.Explanation => @"[original] Catch clauses cannot follow the general catch clause of a try statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1017";
}
