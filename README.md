# PKSound


PK Sound Code Test

Mars Rovers Project

Candidate: Paul Cann

Position applied for:  Intermediate Software Developer

Date: 29/06/20


Abstract
This document is intended to demonstrate my approach to developing software.  I will outline the decisions I made, principles I adhered to and testing results, based on the specification provided.       


Approach

I made the decision to use Test Driven Development (TDD) which, essentially means, I write the test suite first and then write code to make that test pass.  I used S.O.L.I.D principles, particularly the interface segregation principle.   

I drew a grid, as per the specification, and plotted the example rover’s journeys as new instructions were given.  This way I can use this data to test each step of my coed to make sure it’s doing what I expected.

The expected results were as follows:

Starting position: “1 2 N” 
End position: “1 3 N”
Instruction	Position
L	1 2 W
M	0 2 W
L	0 2 S
M	0 1 S
L	0 1 E
M	1 1 E
L	1 1 N
M	1 2 N
M	1 3 N

The second rover’s results are as follows:
Starting position: “3 3 E”
End position: “5 1 E”
Instruction	Position
M	4 3 E
M  	5 3 E
R	5 3 S
M	5 2 S
M	5 1 S
R	5 1 W
M	4 1 W
R	4 1 N
R 
M	4 1 E
5 1 E

Algorithm

The first job of my code is to read in boundary coordinates for the plateau that the rovers will explore.  The bottom left coordinates are assumed to be (0,0), as per the specification.  Therefore I just need the user to enter the top right coordinates:
-	get input
o	set constant grid Border upper x to first number entered
o	set constant grid Border upper y to second number entered
o	set constant grid Border lower x to 0
o	set constant grid Border lower y to 0

Next was to establish what behaviour is expected when I rotate a rover both left and right. 

Direction 
-	Rotate Left
o	if  input letter == L, rotate rover by existing value – 90 degrees
	N == W, W == S, S = E, E == N

-	Rotate Right
o	if  input letter == R, rotate rover by existing value + 90 degrees
	N == E, E == S, S = W, W == N

-	Advance
o	Get the direction rover is facing
	If rover orientation == ‘N’ then rover.y  += 1
	If rover orientation == ‘E’ then rover.x  += 1
	If rover orientation == ‘W’ then rover.x  -= 1
	If rover orientation == ‘S’ then rover.y   -= 1

I incorporated some error checking in my code.  However, this is what I intended to do.  It was not a requirement but I wanted to go beyond the expectation.
-	Check input is valid
o	Check coords are ints
o	Check orientation is char and one of ‘N’. ‘E’, ‘W’, ‘S’
-	Check that move is legal
o	If rover.x == 0 and direction == W or
o	If rover.x == 5 and direction ==  E or 
o	If rover.y == 0 and direction ==  S or
o	If rover.y == 5 and direction ==  N or
	If  instruction == M, display error

Classes

Name: Plateau
Access: public sealed 
Constructor: to set maximum value coordinates, mininmum is assumed to be (0,0), as per specification 
Public variables: upper_x, upper_y, lower_x, lower_y

Name: Rover
Access: public
Public variables name, position and instructions
Methods: SetRoverName
SetInitialPosition
GetInstructions
rotateRight
rotateLeft
AdvanceX
AdvanceY


Interfaces

IAdvance
IGetInstructions
IRotateLeft
IRotateRight
ISetInitialPosition
ISetRoverName


