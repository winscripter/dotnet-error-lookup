namespace dotnet_error_lookup.Data.Errors;

public class CS1918 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1918";
    string IErrorOrWarning.Message => @"Members of property '{0}' of type '{1}' cannot be assigned with an object initializer because it is of a value type";
    string IErrorOrWarning.Explanation => @"[original] Members of property '{0}' of type '{1}' cannot be assigned with an object initializer because it is of a value type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1918";
}
