
/*
using Ioc_Di.Domain;
using NSubstitute;
using NUnit.Framework;

namespace TestsProject {
    [TestFixture]
    public class MessageServiceTests {
        //private IMessageService messageServiceMock;
        private IMessageService _messageService;
        private Email _emailService;
        private SMS _SMSService;

        [SetUp]
        public void SetUp() {
            //messageServiceMock = Substitute.For<IMessageService>();
            _messageService = new MessageService();
            _emailService = new Email();
            _SMSService = new SMS();

        }

        [Test]
        public void EmailService_Should_Send_Email() {

            var expectedMessage = _emailService.SendMessage("Test");

            Assert.That(expectedMessage, Is.EqualTo("Sending email: Test"));

            //messageServiceMock.Received(1).SendMessage(Arg.Any<string>());
        }

        [Test]
        public void SMSService_Should_Send_SMS() {


            var expectedMessage = _SMSService.SendMessage("Test");

            Assert.That(expectedMessage, Is.EqualTo("Sending SMS: Test"));

            //messageServiceMock.Received(1).SendMessage(Arg.Any<string>());


        }
    }
}
*/