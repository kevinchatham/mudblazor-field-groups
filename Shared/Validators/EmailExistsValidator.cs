namespace FieldGroups.Shared.Validators;

public sealed class EmailExistsValidator : BaseValidator<string>
{
    // readonly IUsersRepository _usersRepository;

    // public EmailExistsValidator(IUsersRepository usersRepository)
    // {
    //     _usersRepository = usersRepository;
    // }

    public sealed override Func<string, Task<IEnumerable<string>>> Validate => async (string s) =>
    {
        var errors = new List<string>();
        var emailValidator = new EmailValidator();
        var emailValidatorErrors = await emailValidator.Validate(s);
        if (emailValidatorErrors.Count() != 0)
            return emailValidatorErrors.AsEnumerable();
        // var user = await _usersRepository.GetByEmail(s);
        // if (user != null)
        //     errors.Add("Email address already exists");
        return errors.AsEnumerable();
    };
}