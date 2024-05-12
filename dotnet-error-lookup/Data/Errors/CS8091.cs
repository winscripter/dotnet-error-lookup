namespace dotnet_error_lookup.Data.Errors;

public class CS8091 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8091";
    string IErrorOrWarning.Message => @"'{0}' cannot be extern and have a constructor initializer";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be extern and have a constructor initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
