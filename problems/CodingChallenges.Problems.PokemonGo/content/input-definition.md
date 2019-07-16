The first line of an input file for this problem 
will contain 3 integers, *N*, *T*, and *K*, the number of PokeStops, the time limit, and the polling interval, respectively. 
The following *N* lines will contain 2 integers describing the (X, Y) coordinates of each PokeStop in the order that you must travel to them. 

The following constraints apply:
+ 2 &le; *N* &le; 10
+ 3 &le; *K* &le; 100
+ -10<sup>5</sup> &lt; X, Y &lt; 10<sup>5</sup>
+ *D* &le; *T* &le; _D_ + (*N*_K_ / 2) where *D* is the total distance of the path that needs to be walked.
+ You will always have enough time to complete the path.