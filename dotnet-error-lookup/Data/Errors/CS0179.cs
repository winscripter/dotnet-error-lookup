namespace dotnet_error_lookup.Data.Errors;

public class CS0179 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0179";
    string IErrorOrWarning.Message => @"'{0}' cannot be extern and declare a body";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be extern and declare a body";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0179";
}
