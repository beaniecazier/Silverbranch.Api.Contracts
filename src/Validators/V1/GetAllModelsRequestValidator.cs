using FluentValidation;

using Gay.Silverbranch.Api.Utilities.Contract.Requests.V1;

namespace Gay.Silverbranch.Api.Utilities.Contract.Validators.V1;

public class GetAllModelsRequestValidator : 
    AbstractValidator<GetAllModelsRequest>
{
    private static readonly string[] AcceptableSortFields =
    {
        "Name", "ModifiedBy", "ModifiedOn", "HiddenOn", "DeletedOn", "EntryIdentity", "CommonIdentity", ""
    };

    public GetAllModelsRequestValidator()
    {
        // RuleFor(x => x.GreaterThanOrEqualToId)
        //     .GreaterThanOrEqualTo(0)
        //     .When(x=>x.GreaterThanOrEqualToId.HasValue);
        // RuleFor(x => x.LessThanOrEqualToId)
        //     .GreaterThanOrEqualTo(0)
        //     .When(x => x.LessThanOrEqualToId.HasValue);

        RuleFor(x => x.SortBy)
            .Must(x => x is null || AcceptableSortFields.Contains(x))
            .WithMessage($"The only acceptable sorting fields are:\n{string.Join("\n", AcceptableSortFields)}");
    }
}