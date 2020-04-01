# MSMessageQueuing
Testing MS Message Queuing service for potential use in distributed parallel computing.


## Sources
Sources of information:
* https://en.wikipedia.org/wiki/Microsoft_Message_Queuing
* https://www.youtube.com/watch?v=GArHz5YhThQ
* https://www.simpleorientedarchitecture.com/msmq-basics/
* https://www.infoworld.com/article/3060115/how-to-work-with-msmq-in-c.html
.
Much info: https://docs.microsoft.com/en-us/previous-versions/windows/desktop/msmq/ms711436(v=vs.85)


## How to enable on Windows 10
Install it via:
![Turn on MSMQ](Illustrations\TurnOnMSMQ.PNG)

Then one can access the queues using:
![Computer Management](Illustrations\ComputerManagement.PNG)

![Message Queuing](Illustrations\ComputerManagementMSMQ.PNG)

Access


## On queues
Notes:
* Queues can be transactional or nontransactional.
* Two categories of queues: Application Queues or System Queues.

See: https://docs.microsoft.com/en-us/previous-versions/windows/desktop/msmq/ms704006(v%3Dvs.85)

Application queues:
* Public queues.
* Private queues (local machine).
* Administration queues.
* Response Queues.
* Report Queues.

System queues:
* Dead-Letter queues.
* Outgoing Queues.
* Journal Queues.
* Private System queues.

Accessing queues:
* Via path name.
* Via format name.
* Via direct format name.
* Via properties.

Messages:
* Acknowledgement messages.
* Report messages.
* Express or recoverable:
  * Express messages are stored in ram.
  * Recoverable are stored on disk.

Timers:
* Time-to-reach-queue.
* Time-to-be-reached.

Messages can be no more than 4MB.

Message delivery assurance:
* At-most-once.
  * Best-effort express delivery.
  * Best-effort delivery.
* Exactly once.


## Practical implementation

### Sending and receiving any type (like serialization)
One can send and receive messages of any type by using:  
*message.Formatter = new XmlMessageFormatter(new string[] { "System.String, mscorlib" });*

The above is for a string, but any object type can be send. Such as:
*message.Formatter = new XmlMessageFormatter(new double[] { "System.Double, mscorlib" });*
*message.Formatter = new XmlMessageFormatter(new Type[] { typeof(Double) });*



## Other stuff
Other relevant stuff.


### Using statement
The using statement for the correct use of the IDisposable interface.
See using: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
See IDisposable: https://docs.microsoft.com/en-us/dotnet/api/system.idisposable?view=netframework-4.8


