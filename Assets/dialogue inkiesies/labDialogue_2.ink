#lab dialogue
VAR viewtimes = 0
->lab
== lab ==
{ viewtimes < 1:
When you enter the lab, it's almost like a maze.
* [Continue]
Without a lead, you're willing to do anything to get in and out of this place, so it seems like looking around for a way through that locked door is the only option.
~ viewtimes = viewtimes + 1
->lab
- else:
->END
}