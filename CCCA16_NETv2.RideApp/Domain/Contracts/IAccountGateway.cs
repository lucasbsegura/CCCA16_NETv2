namespace CCCA16_NETv2.RideApp.Domain.Contracts
{
    public interface IAccountGateway
    {
        Task<AccountOutput> GetAccountById(Guid accountId);
        Guid Signup(SignUpInput input);
    }

    public struct SignUpInput
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string CarPlate { get; set; }
        public bool IsPassenger { get; set; }
        public bool IsDriver { get; set; }
    }

    public record AccountOutput(Guid AccountId, string Name, string Email, string Cpf, string CarPlate, bool IsPassenger, bool IsDriver)
    {
        public Guid AccountId { get; } = AccountId;
        public string Name { get; } = Name;
        public string Email { get; } = Email;
        public string Cpf { get; } = Cpf;
        public string CarPlate { get; } = CarPlate;
        public bool IsPassenger { get; } = IsPassenger;
        public bool IsDriver { get; } = IsDriver;
    }
}
