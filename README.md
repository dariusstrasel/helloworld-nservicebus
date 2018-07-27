# NServiceBus Hello World

This is a demo project used to onboard myself (@DariusStrasel) with the NServiceBusPlatform

- [Theoretical Resources](https://app.pluralsight.com/player?course=microservices-nservicebus6-scaling-applications)
- [Practical Resources](https://docs.particular.net/tutorials/quickstart/)

## Key Concepts
- Message is a contract between endpoints
- Message should have their own assembly (as should an endpoint)
- Every Message should have an associated Handler<MessageType> and named in the Imperative sense, such as "PlaceOrder"

- Logical routing allows the developer to tell the transport which endpoint a message should be sent to. This is defined via the transport object, and shouldn't be defined via Send().

### Commands/Events
- Commands and events are quite different, and as a result require different architectural designs.
- Events should be named in the imperative past tense, such as "OrderPlaced"

### Pub/Sub
- Using a pub/sub pattern between event sends and recievers, allows for loose coupling between endpoints, whereas messages use tight coupling between two endpoints  
"From this comparison, it's clear that commands and events will sometimes come in pairs. A command will arrive, perhaps from a website UI, telling the system to DoSomething. The system does that work, and as a result, publishes a SomethingHappened event, which other components in the system can react to."

### Saga
- If using the Saga pattern to handle dependant messages:
-- You must ensure there isn't a depdency on order, allowing each Message type to be passed into ICanStartSaga<T> will resolve this.
-- Each saga policy must use an ID as a mapper between the different message types and the instantiated saga state.
