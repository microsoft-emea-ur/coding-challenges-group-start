Contoso is considering branching its business into a new industry: dry cleaning. Contoso, however, won't just enter a new industry without a ground-breaking strategy. 
Contoso's new strategy for dry cleaning will be a multi-step process that requires a clothing item to go through a series of machines, 
much like how home laundry goes through the washer followed by the dryer. The new process, however, will require many more machines and each machine will take a fixed amount of time to process a load.

For example, let's assume 100 loads of laundry need to be processed through 4 machines in order. 
The time to run each load in the machines are 1, 1, 1, and 3 minutes, in that order. 
Since the machines run independently, once the first load is done in the first machine, it will be moved to the second machine, and the second load will immediately be started in the first machine. 
This starts the pipeline. If a machine completes a load, the next machine must be empty for the current load to progress. All loads move instantaneously. For this example, the 100 loads of laundry will complete in 303 minutes.

A new technology has now been created that allows one to combine any number of consecutive machines into a single machine; the new combined machine's processing time is equal to the sum of the original machines' processing times. 
The capacity of each machine remains the same. 
For the above example, you could reduce the pipeline to two machines with times of 3 and 3. In that case, the time to complete 100 loads with the reduced pipeline is the same: 303 minutes. If, however we reduced the pipeline to a 
single machine with a time of 6, the time to complete 100 loads would be 600 minutes. Ouch!

Your program should compute the minimum number of machines the pipeline could be without increasing the time to complete a given number of loads.