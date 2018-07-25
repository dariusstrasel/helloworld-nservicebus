# NServiceBus Hello World

This is a demo project used to onboard myself (@DariusStrasel) with the NServiceBusPlatform

- [Theoretical Resources](https://app.pluralsight.com/player?course=microservices-nservicebus6-scaling-applications)
- [Practical Resources](https://docs.particular.net/tutorials/quickstart/

## Key Concepts
- Message is a contract between endpoints
- Message should have their own assembly (as should an endpoint)
- Every Message should have an associated Handler<MessageType>

- Logical routing allows the developer to tell the transport which endpoint a message should be sent to. This is defined via the transport object, and shouldn't be defined via Send().
