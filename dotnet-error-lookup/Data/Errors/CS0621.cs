namespace dotnet_error_lookup.Data.Errors;

public class CS0621 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0621";
    string IErrorOrWarning.Message => @"'{0}': virtual or abstract members cannot be private";
    string IErrorOrWarning.Explanation => @"[original] '{0}': virtual or abstract members cannot be private";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0621";
}
