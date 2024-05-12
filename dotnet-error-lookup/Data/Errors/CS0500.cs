namespace dotnet_error_lookup.Data.Errors;

public class CS0500 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0500";
    string IErrorOrWarning.Message => @"'{0}' cannot declare a body because it is marked abstract";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot declare a body because it is marked abstract";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0500";
}
