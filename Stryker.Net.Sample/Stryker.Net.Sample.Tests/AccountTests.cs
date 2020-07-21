using FluentAssertions;
using Xunit;

namespace Stryker.Net.Sample.Tests
{
    public class AccountTest
    {
        [Fact]
        public void Should_create_new_account_with_overdraft()
        {
            //Arrange
            var owner = "Jack"; 
            var overdraft = true; 
            
            //Act
            var account = new Account(owner, overdraft);
            
            //Assert
            account.Balance.Should().Be(default);
            account.Id.Should().NotBe(default);
            account.Owner.Should().Be(owner);
            account.Overdraft.Should().Be(overdraft);
        }        
        
        [Fact]
        public void Should_create_new_account_without_overdraft()
        {
            //Arrange
            var owner = "Jack"; 
            var overdraft = false; 
            
            //Act
            var account = new Account(owner, overdraft);
            
            //Assert
            account.Balance.Should().Be(default);
            account.Id.Should().NotBe(default);
            account.Owner.Should().Be(owner);
            account.Overdraft.Should().Be(overdraft);
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
                .WhithoutOverdraft()
                .WithInitialAmount(initialBalance)
                .Build();
            
            //Act
            account.WithdrawMoney(amountToWithdrawn);
            
            //Assert
            account.Balance.Should().Be(initialBalance - amountToWithdrawn);
        }
    }
}