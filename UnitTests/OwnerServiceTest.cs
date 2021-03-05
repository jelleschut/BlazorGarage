using Domain.Interfaces;
using Domain.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Services;
using Web.Utils;
using Xunit;

namespace UnitTests
{
    public class OwnerServiceTest
    {
        [Fact]
        public void ValidateValidObject()
        {
            //Arrange
            var fixture = new OwnerServiceFixture();

            //Act
            bool result = fixture.ExecuteValidateOwner();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateNullObject()
        {
            //Arrange
            var fixture = new OwnerServiceFixture()
                .WithNullOwnerObject();

            //Act
            bool result = fixture.ExecuteValidateOwner();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidateInvalidObject()
        {
            //Arrange
            var fixture = new OwnerServiceFixture()
                .WithNullOwnerName();

            //Act
            bool result = fixture.ExecuteValidateOwner();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AddValidOwner()
        {
            //Arrange
            var fixture = new OwnerServiceFixture();

            //Act
            fixture.ExecuteAddOwner();

            //Assert
            fixture.AssertOwnerInsertedInDatabase();
        }

        [Fact]
        public void AddNullOwner() 
        {
            //Arrange
            var fixture = new OwnerServiceFixture()
                .WithNullOwnerObject();

            //Act
            fixture.ExecuteAddOwner();

            //Assert
            fixture.AssertOwnerNotInsertedInDatabase();
        }

        [Fact]
        public void AddNullNameOwner()
        {
            //Arrange
            var fixture = new OwnerServiceFixture()
                .WithNullOwnerName();

            //Act
            fixture.ExecuteAddOwner();

            //Assert
            fixture.AssertOwnerNotInsertedInDatabase();
        }

        [Fact]
        public void UpdateValidOwner()
        {
            //Arrange
            var fixture = new OwnerServiceFixture();

            //Act
            fixture.ExecuteUpdateOwner();

            //Assert
            fixture.AssertOwnerUpdatedInDatabase();
        }

        [Fact]
        public void UpdateNullOwner()
        {
            //Arrange
            var fixture = new OwnerServiceFixture()
                .WithNullOwnerObject();

            //Act
            fixture.ExecuteUpdateOwner();

            //Assert
            fixture.AssertOwnerNotUpdatedInDatabase();
        }

        [Fact]
        public void UpdateNullNameOwner()
        {
            //Arrange
            var fixture = new OwnerServiceFixture()
                .WithNullOwnerName();

            //Act
            fixture.ExecuteUpdateOwner();

            //Assert
            fixture.AssertOwnerNotUpdatedInDatabase();
        }

    }

    internal class OwnerServiceFixture
    {
        Mock<IOwnerRepository> _stubOwnerRepository;
        X509Encryptor _encryptor;

        Owner _owner = new Owner
        {
            Name = "Jelle",
            City = "Deventer",
            Street = "Keizer Frederikstraat",
            HouseNumber = "77",
            Zipcode = "7415KC",
            Email = "jelleschut@hotmail.com",
            PhoneNumber = "0657013971",
            OwnerType = Domain.Enums.OwnerEnum.DRIVER
        };

        public OwnerServiceFixture()
        {
            _stubOwnerRepository = new Mock<IOwnerRepository>();
            _encryptor = new X509Encryptor();
        }

        public OwnerServiceFixture WithNullOwnerObject()
        {
            _owner = null;
            return this;
        }

        public OwnerServiceFixture WithNullOwnerName()
        {
            _owner.Name = null;
            return this;
        }

        public OwnerServiceFixture WithTypeLeaseCompany()
        {
            _owner.OwnerType = Domain.Enums.OwnerEnum.LEASECOMPANY;
            return this;
        }

        public bool ExecuteValidateOwner()
        {
            OwnerService sut = new OwnerService(_stubOwnerRepository.Object);
            return sut.IsValid(_owner);
        }

        public async void ExecuteAddOwner()
        {
            OwnerService sut = new OwnerService(_stubOwnerRepository.Object);
            await sut.Add(_owner);
        }

        public async void ExecuteUpdateOwner()
        {
            OwnerService sut = new OwnerService(_stubOwnerRepository.Object);
            await sut.Update(_owner);
        }

        public void AssertOwnerInsertedInDatabase()
        {
            _stubOwnerRepository.Verify(x => x.AddAsync(_owner));
        }
        public void AssertOwnerNotInsertedInDatabase()
        {
            _stubOwnerRepository.Verify(x => x.AddAsync(_owner), Times.Never());
        }
        public void AssertOwnerUpdatedInDatabase()
        {
            _stubOwnerRepository.Verify(x => x.UpdateAsync(_owner));
        }
        public void AssertOwnerNotUpdatedInDatabase()
        {
            _stubOwnerRepository.Verify(x => x.UpdateAsync(_owner), Times.Never());
        }

    }
}
