using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication.Notifications
{
    public class ValueAddedNotification : INotification 
    {
        public string Value { get; set; }
    }

    public class EmailHandler : INotificationHandler<ValueAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public EmailHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public Task Handle(ValueAddedNotification notification, CancellationToken cancellationToken)
        {
            _fakeDataStore.EventOccured(notification.Value, "Email sent");
            return Task.CompletedTask;
        }
    }

    public class CacheInvalidationHandler : INotificationHandler<ValueAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public CacheInvalidationHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public Task Handle(ValueAddedNotification notification, CancellationToken cancellationToken)
        {
            _fakeDataStore.EventOccured(notification.Value, "Cache invalidated");
            return Task.CompletedTask;
        }
    }
}
