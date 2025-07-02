using FluentValidation;
using Gay.Silverbranch.API.Utilities.Contract.Requests;
using Gay.Silverbranch.API.Utilities.Contract.Requests.V1;

namespace Gay.Silverbranch.API.Utilities.Contract.Validators.V1;

public class PostBaseModelRequestValidator<T> : AbstractValidator<T>
where T : PostBaseModelRequest
{
    public PostBaseModelRequestValidator()
    {
        //verify name and notes are not sql injection attacks
        // make sure name is within string length requirements 
        RuleFor(x => x.Name).NotNull().NotEmpty().Length(1, 128);
    }
}