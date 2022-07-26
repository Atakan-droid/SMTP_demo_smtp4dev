using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using System.Threading.Tasks;
using Xunit;

namespace SMTP4_Tests
{
    public class SmtpFactory : IAsyncLifetime
    {
        private readonly TestcontainersContainer _container =
            new TestcontainersBuilder<TestcontainersContainer>()
            .WithImage("rnwood/smtp4dev")
            .WithPortBinding(3001, 80)
            .WithPortBinding(2526, 25)
            .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(2525))
            .Build();

        public async Task DisposeAsync()
        {
            await _container.DisposeAsync();
        }

        public async Task InitializeAsync()
        {
            await _container.StartAsync();
        }
    }
}
