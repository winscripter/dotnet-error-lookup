namespace dotnet_error_lookup.Data.Errors;

public class CS1686 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1686";
    string IErrorOrWarning.Message => @"Local '{0}' or its members cannot have their address taken and be used inside an anonymous method or lambda expression";
    string IErrorOrWarning.Explanation => @"[original] Local '{0}' or its members cannot have their address taken and be used inside an anonymous method or lambda expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1686";
}
