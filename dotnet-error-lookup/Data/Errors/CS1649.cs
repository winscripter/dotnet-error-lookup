namespace dotnet_error_lookup.Data.Errors;

public class CS1649 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1649";
    string IErrorOrWarning.Message => @"Members of readonly field '{0}' cannot be used as a ref or out value (except in a constructor)";
    string IErrorOrWarning.Explanation => @"[original] Members of readonly field '{0}' cannot be used as a ref or out value (except in a constructor)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1649";
}
