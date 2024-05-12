namespace dotnet_error_lookup.Data.Errors;

public class CS1662 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1662";
    string IErrorOrWarning.Message => @"Cannot convert {0} to intended delegate type because some of the return types in the block are not implicitly convertible to the delegate return type";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert {0} to intended delegate type because some of the return types in the block are not implicitly convertible to the delegate return type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1662";
}
