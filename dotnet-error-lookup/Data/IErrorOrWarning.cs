namespace dotnet_error_lookup.Data;

public interface IErrorOrWarning
{
    SyntaxErrorType ErrorType { get; }
    string Name { get; }
    string Message { get; }
    string Explanation { get; }
    string SampleCode { get; }
    string SampleFix { get; }
    string DocumentationReference { get; }
}
