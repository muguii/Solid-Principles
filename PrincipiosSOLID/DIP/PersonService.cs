namespace PrincipiosSOLID.DIP
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IErpSyncService _erpSyncService;
        private readonly IMessageBusService _messageBusService;

        public PersonService(IPersonRepository personRepository, IErpSyncService erpSyncService, IMessageBusService messageBusService)
        {
            this._personRepository = personRepository;
            this._messageBusService = messageBusService;
            this._erpSyncService = erpSyncService;
        }

        public void Add(PersonDto dto)
        {
            var person = new Person(dto.Name, dto.Document, dto.BirthDate);

            _personRepository.Add(person);
            _erpSyncService.SyncPerson(person);
            _messageBusService.Publish("nomeFila", person);
        }
    }
}
