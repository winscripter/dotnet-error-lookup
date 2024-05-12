namespace dotnet_error_lookup.Data.Errors;

public class CS0538 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0538";
    string IErrorOrWarning.Message => @"'{0}' in explicit interface declaration is not an interface";
    string IErrorOrWarning.Explanation => @"[original] '{0}' in explicit interface declaration is not an interface";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0538";
}
