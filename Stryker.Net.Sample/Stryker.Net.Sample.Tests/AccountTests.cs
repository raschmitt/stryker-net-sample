using FluentAssertions;
using Xunit;

namespace Stryker.Net.Sample.Tests
{
    public class AccountTest
    {
        [Fact]
        public void Should_create_new_account()
        {
            //Arrange
            var owner = "Jack"; 
            
            //Act
            var account = new Account(owner);
            
            //Assert
            account.Balance.Should().Be(default);
            account.Overdraft.Should().Be(default);
            account.Id.Should().NotBe(default);
            account.Owner.Should().Be(owner);
        }        
        
        [Fact]
        public void Should_enable_overdraft()
        {
            //Arrange
            var account = new AccountBuilder().Build();
            
            //Act
            account.EnableOverdraft();
            
            //Assert
            account.Overdraft.Should().Be(true);
        }
        
        [Fact]
        public void Should_disable_overdraft()
        {
            //Arrange
            var account = new AccountBuilder()
                .WithOverdraft()
                .Build();
            
            //Act
            account.DisableOverdraft();
            
            //Assert
            account.Overdraft.Should().Be(account.Overdraft);
        }
        
        [Fact]
        public void Should_add_to_account()
        {
            //Arrange
            var amountToAdd = 500;
            
            var account = new AccountBuilder().Build();
            
            //Act
            account.AddMoney(amountToAdd);
            
            //Assert
            account.Balance.Should().Be(amountToAdd);
        }
        
        [Fact]
        public void Should_withdrawn_from_account_with_overdraft()
        {
            //Arrange
            var initialBalance = 200;
            var amountToWithdrawn = 350;
            
            var account = new AccountBuilder()
                .WithOverdraft()
                .WithInitialAmount(initialBalance)
                .Build();
            
            //Act
            account.WithdrawMoney(amountToWithdrawn);
            
            //Assert
            account.Balance.Should().Be(initialBalance - amountToWithdrawn);
        }
        
        [Fact]
        public void Should_withdrawn_from_account_without_overdraft()
        {
            //Arrange
            var initialBalance = 500;
            var amountToWithdrawn = 350;
            
            var account = new AccountBuilder()
                .WithInitialAmount(initialBalance)
                .Build();
            
            //Act
            account.WithdrawMoney(amountToWithdrawn);
            
            //Assert
            account.Balance.Should().Be(initialBalance - amountToWithdrawn);
        }
    }
}