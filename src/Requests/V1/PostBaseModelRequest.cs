using Swashbuckle.AspNetCore.Annotations;

namespace Gay.Silverbranch.API.Utilities.Contract.Requests.V1;

public class PostBaseModelRequest
{
    [SwaggerSchema(Description = "hi", Format = "7")]
    public required string Name { get; init; } = string.Empty;

    [SwaggerSchema(Description = "hi", Format = "7")]
    public string Notes { get; set; } = string.Empty;
}
