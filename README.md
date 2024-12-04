# Game_Engines_Final_Exam
 
I first made prefabs for all 7 different tile shapes and put a box collider 2d on them and a rigid body 2d

I implemented object pooling by using a Tile Pool 

To do this I had first to declare what prefabs I wanted in this pool, and then I have a list of tiles. The list of tiles is a list of game objects. I then have a function called GetTile() which first gets a random number between 0-7 and then it checks if there is a tile already in the pool to use if not then not enough tiles bool is true and the game instantiates a new tile based on the random number we got corresponding to a random tile shape. 

I then have a tile behaviour script to add to the tiles 

To spawn the tiles I have a spawning script that starts a spawn coroutine to spawn a random tile from the tilepool. 

This is great as when tiles are deleted they are instead just deactivated and can be reused and reactivated instead of having to always delete and recreate new tiles saving a lot of memory and garbage collection 

I also implemented an end goal trigger box and script, that will check if the tiles have hit the bottom, if the tile hits the bottom of the scene it will deactivate and it will notify the observer. 

I have a UI manager that is an Observer who will listen to the end goal and add and display the correct score based on how many tiles hit the bottom of the scene. 

Overall I was able to add working Observer and working object pooling into the game with all 7 different tile shapes working as well. 
