# Grasshopper/Rhino to Unity3D Test 'Game' 

Calling this a game is a little disingenoious, a lot of the gamicification features we didn't really have time to implement

This app allows users to visualize and explore a algorithmically generated labyrinth in realtime. We've bundled it with a labyrinth that changes as the user approaches a preset goal.

The entropy/energy of the system increases as the user gets further through the labyrinth.

==Installation==

-Requirements: 
--MongoDB
--Redis
--Rhino 6
--Node/NPM
-- Plugins for rhino 6:
	--- Human
	--- Meshedit
	--- Speckle for Rhino
	
-- To launch: 

--Start the mongo, redis, and bundled speckle server via node
--Launch the rhino environment attached
-- Start the unity executable

