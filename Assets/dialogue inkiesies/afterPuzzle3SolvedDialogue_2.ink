# after puzzle 3 gets solved
VAR viewtimes = 0
->lab2
== lab2 ==
{ viewtimes < 1:
You finished building the robot! Maybe you should rethink your career choices. Drill open the case with the robot you just built.
* [Obtain contents.]
It's a document. It says that there's a structural flaw in all the robots that the scientist builds. There's a chemical that could possibly disable them.
** [Continue.]
You remember the robot guarding the door from before. Maybe the chemical mentioned could disable the robot and let you go inside.
~ viewtimes = viewtimes + 1
->lab2
- else:
->END
}