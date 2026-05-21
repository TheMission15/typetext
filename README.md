# typetext

Instructions:
type - loads integer input into the accumulator
get x - loads x into the accumulator
set x - saves the accumulator into x
add x - increments accumulator by x
negate - swaps accumulator sign
over x - sets accumulator to 1 if its greater than x, -1 if its less than x and 0 if its equal to x
check x - skips next word if accumulator != x
label x - saves x as a location in memory
goto x - set pc equal to x
rand x - random number between 0 and x
line - loads the value of pc into accumulator
send x - outputs x
clear - clears the console
close - ends the program

Rules:
words are split by white space and stored into a queue
after each pc increment the word is checked for if it is command if it is not used as variable
'label's are found in a check before running the program, as well as a program cannot be run without a mention of 'close'
values of labels are saved into the memory
'over's return a 1 if accumulator is greater than, a -1 if it is less than and a 0 if it is equal to x
'goto's set the pc equal to the value of the variable after it

variables/values are represented by values which come after most instructions, if the word after an instruction is an integer, it will be treated as such, otherwise the memory will be checked for a variable with the same name, if it fails both, a 0 is used
