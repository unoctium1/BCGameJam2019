# Grasshopper/Rhino to Unity3D Test 'Game' 

Made for BC Game Jam 2019

Calling this a game is a little disingenuous, a lot of the gamicification features we didn't really have time to implement

This app allows users to visualize and explore an algorithmically generated labyrinth in realtime. We've bundled it with a labyrinth that changes as the user approaches a preset goal.

The entropy/energy of the system increases as the user gets further through the labyrinth, and the grasshopper files can be further modified at runtime

## Installation

Requirements: 
 - MongoDB
 - Redis
 - Rhino 6
 - Node/NPM
 - Plugins for rhino 6:
 	- Human
	- Meshedit
	- Speckle for Rhino
	- gHowl
	
## To launch Local Environment 

- Start the mongo, redis, and bundled speckle server via node
- Launch the rhino environment attached
- Start the unity executable

## To launch Hosted Environment 

- Start the unity executable
- Modifying and using custom hosted environments will be added in a later version
