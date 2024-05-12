namespace dotnet_error_lookup.Data.Errors;

public class CS0439 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0439";
    string IErrorOrWarning.Message => @"An extern alias declaration must precede all other elements defined in the namespace";
    string IErrorOrWarning.Explanation => @"[original] An extern alias declaration must precede all other elements defined in the namespace";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0439";
}
