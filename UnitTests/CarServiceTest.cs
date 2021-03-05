using System;
using Xunit;
using Moq;
using Domain.Interfaces;
using Web.Services.Interfaces;
using Web.Utils;
using Domain.Models;

namespace UnitTests
{
    public class CarServiceTest
    {
        [Fact]
        public void Test1()
        {

        }
    }

    internal class CarServicFixture
    {
        Mock<ICarRepository> _stubCarRepository;
        Mock<IOwnerRepository> _stubOwnerRepository;
        Mock<IOwnerService> _stubOwnerService;
        Mock<X509Encryptor> _stubEncryptor;

        public CarServicFixture()
        {
            _stubCarRepository = new Mock<ICarRepository>();
            _stubOwnerRepository = new Mock<IOwnerRepository>();
            _stubOwnerService = new Mock<IOwnerService>();
            _stubEncryptor = new Mock<X509Encryptor>();
        }


    }
}
