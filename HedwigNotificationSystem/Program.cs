using HedwigNotificationSystem.Extensions;
using HedwigNotificationSystem.MessageBroker.Options;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddServices(builder.Configuration);
builder.Configuration.AddEnvironmentVariables();

var host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var connectionFactory = scope.ServiceProvider.GetRequiredService<ConnectionFactory>();
    using var connection = connectionFactory.CreateConnection();
    using var channel = connection.CreateModel();
    var queues = scope.ServiceProvider.GetRequiredService<IOptions<ConsumerConfiguration>>().Value;
    var userNotificationsQueue = queues.UserNotificationsQueue;
    channel.QueueDeclare(queue: userNotificationsQueue,
                         durable: true,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);
}

host.Run();
