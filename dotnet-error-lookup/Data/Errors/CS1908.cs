namespace dotnet_error_lookup.Data.Errors;

public class CS1908 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1908";
    string IErrorOrWarning.Message => @"The type of the argument to the DefaultParameterValue attribute must match the parameter type";
    string IErrorOrWarning.Explanation => @"[original] The type of the argument to the DefaultParameterValue attribute must match the parameter type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1908";
}
