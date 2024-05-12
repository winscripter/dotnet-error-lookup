namespace dotnet_error_lookup.Data.Errors;

public class CS0539 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0539";
    string IErrorOrWarning.Message => @"'{0}' in explicit interface declaration is not found among members of the interface that can be implemented";
    string IErrorOrWarning.Explanation => @"[original] '{0}' in explicit interface declaration is not found among members of the interface that can be implemented";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0539";
}
