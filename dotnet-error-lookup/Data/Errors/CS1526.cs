namespace dotnet_error_lookup.Data.Errors;

public class CS1526 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1526";
    string IErrorOrWarning.Message => @"A new expression requires an argument list or (), [], or {} after type";
    string IErrorOrWarning.Explanation => @"[original] A new expression requires an argument list or (), [], or {} after type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1526";
}
