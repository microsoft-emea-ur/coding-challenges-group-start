You have built a cloud solution that uses many micro services. Each micro service communicates to other micro services using messages. Each message has a unique type. Each instance costs money, so you need to make sure you don't overspend to make your service work.

Each micro service consumes a single message type at a given rate (possibly more than one message at a time) while also producing one or more types of messages (possibly more than one of each type at a time). 
One service does not consume, but only produces messages. In addition, some services only consume messages.

Your objective is to find the minimal number of instances of each micro service needed to consume all of the messages that have been generated.

The following restrictions shall apply for this problem:
* You must have at least one of each service
* There will be one service that produces an output and has no inputs (this is a generator service)
* There will be only one service that consumes a specific message type
* There will be only one service that produces a specific message type
* There will be no services that consume more than one message type
* There will be some services that produce more than one message type
* There will be several services that produce no outputs (these are terminus services)
* There are no loops in message consumption (e.g. no A->B, B->C, C->A)
* It will always be possible to consume all of the messages.

*Note* For simplicity, a service will produce all of its output messages, regardless of messages it consumes.