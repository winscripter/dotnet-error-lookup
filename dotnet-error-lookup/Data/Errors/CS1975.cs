namespace dotnet_error_lookup.Data.Errors;

public class CS1975 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1975";
    string IErrorOrWarning.Message => @"The constructor call needs to be dynamically dispatched, but cannot be because it is part of a constructor initializer. Consider casting the dynamic arguments.";
    string IErrorOrWarning.Explanation => @"[original] The constructor call needs to be dynamically dispatched, but cannot be because it is part of a constructor initializer. Consider casting the dynamic arguments.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
