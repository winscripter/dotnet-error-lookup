namespace dotnet_error_lookup.Data.Errors;

public class CS1648 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1648";
    string IErrorOrWarning.Message => @"Members of readonly field '{0}' cannot be modified (except in a constructor or a variable initializer)";
    string IErrorOrWarning.Explanation => @"[original] Members of readonly field '{0}' cannot be modified (except in a constructor or a variable initializer)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1648";
}
