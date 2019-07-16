An input file for this program will define a list of micro services, one on each line. Each line will be of this format:  
{Inputs}->{Outputs}:{Time}

{Input} consists of 0 (generator services) or more alphabetical characters representing the input message type and how many of that message the service consumes.

{Output} consists of 0 (terminus services) or more alphabetical characters representing the output message types and how many of each message the service produces.

{Time} is the number of seconds it takes for this service to consume the inputs and produce the outputs.

All input files will satisfy these constraints:
+ There will be at most 50 micro services. 
+ There will be at most 1 generator service. 
+ Each service will consume at most 10 of each message type. 
+ Capital 'A' is a different message type than lower case 'a'.