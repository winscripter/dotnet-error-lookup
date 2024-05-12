namespace dotnet_error_lookup.Data.Errors;

public class CS0191 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0191";
    string IErrorOrWarning.Message => @"A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)";
    string IErrorOrWarning.Explanation => @"[original] A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0191";
}
