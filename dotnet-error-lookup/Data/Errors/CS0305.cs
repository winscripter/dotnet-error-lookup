namespace dotnet_error_lookup.Data.Errors;

public class CS0305 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0305";
    string IErrorOrWarning.Message => @"Using the generic {1} '{0}' requires {2} type arguments";
    string IErrorOrWarning.Explanation => @"[original] Using the generic {1} '{0}' requires {2} type arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0305";
}
