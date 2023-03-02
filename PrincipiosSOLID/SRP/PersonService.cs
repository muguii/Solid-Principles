namespace PrincipiosSOLID.SRP
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;
        private readonly ServiceBusService _serviceBus;
        private readonly ErpSyncService _erpSyncService;

        public PersonService(PersonRepository personRepository, ServiceBusService serviceBus, ErpSyncService erpSyncService)
        {
            this._personRepository = personRepository;
            this._serviceBus = serviceBus;
            this._erpSyncService = erpSyncService;
        }

        public void Add(PersonDto dto)
        {
            var person = new Person(dto.Name, dto.Document, dto.BirthDate);

            _personRepository.Add(person);
            _erpSyncService.SyncPerson(person);
            _serviceBus.Publish("nomeFila", person);
        }
    }
}
