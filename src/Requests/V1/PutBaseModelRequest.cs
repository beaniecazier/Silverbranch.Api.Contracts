using Swashbuckle.AspNetCore.Annotations;

namespace Gay.Silverbranch.Api.Utilities.Contract.Requests.V1;

public class PutBaseModelRequest
{
    [SwaggerSchema(Description = "hi", Format = "7")]
    public required string Name { get; init; } = string.Empty;

    [SwaggerSchema(Description = "hi", Format = "7")]
    public required string Notes { get; init; } = string.Empty;
}
