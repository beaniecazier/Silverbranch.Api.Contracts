namespace Gay.Silverbranch.Api.Utilities.Contract.Responses.V1;

public class BaseModelResponse
{
    public required string Id { get; init; }
    public required string Name { get; init; } = string.Empty;
    //public string Notes { get; set; } = string.Empty;
}
