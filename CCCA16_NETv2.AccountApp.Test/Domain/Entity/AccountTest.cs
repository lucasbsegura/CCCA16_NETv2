﻿using CCCA16_NETv2.AccountApp.Domain.Entity;

namespace CCCA16_NETv2.AccountApp.Test.Domain.Entity
{
    public class AccountTest
    {
        [Theory]
        [InlineData("John Driver", "johndoe@email.com", "71428793860", "A2B4Y67", false, true)]
        [InlineData("John Passenger", "johnpassanger@email.com", "87748248800", "", true, false)]
        public void DeveConstruirAccount(string name, string email, string cpf, string carPlate, bool isPassanger, bool isDriver)
        {
            var createAccount = Account.Create(name, email, cpf, carPlate, isPassanger, isDriver);
            Assert.True(createAccount.AccountId != Guid.Empty);
            Assert.True(createAccount.Name.GetValue() == name);
            Assert.True(createAccount.Email.GetValue() == email);
            Assert.True(createAccount.Cpf.GetValue() == cpf);
            Assert.True(createAccount.CarPlate.GetValue() == carPlate);
            Assert.True(createAccount.IsPassenger == isPassanger);
            Assert.True(createAccount.IsDriver == isDriver);
        }

        [Theory]
        [InlineData("28445d3e-9906-434a-8318-b0890e7afc4a", "John Driver", "johndoe@email.com", "71428793860", "A2B4Y67", false, true)]
        [InlineData("d0365ba2-8474-44e2-a63c-1347b4d43666", "John Passenger", "johnpassanger@email.com", "87748248800", "", true, false)]
        public void DeveRestaurarAccount(Guid accountId, string name, string email, string cpf, string carPlate, bool isPassanger, bool isDriver)
        {
            var createAccount = Account.Restore(accountId, name, email, cpf, carPlate, isPassanger, isDriver);
            Assert.True(createAccount.AccountId == accountId);
            Assert.True(createAccount.Name.GetValue() == name);
            Assert.True(createAccount.Email.GetValue() == email);
            Assert.True(createAccount.Cpf.GetValue() == cpf);
            Assert.True(createAccount.CarPlate.GetValue() == carPlate);
            Assert.True(createAccount.IsPassenger == isPassanger);
            Assert.True(createAccount.IsDriver == isDriver);
        }
    }
}
