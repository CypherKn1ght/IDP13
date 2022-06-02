# office dialogue
VAR viewtimes = 0
->office
== office ==
{ viewtimes < 1:
Looks like this is the office.
* [Continue]
Is that the scientist?!
** [Continue]
The scientist was a robot himself this whole time? Good thing that he's (probably) charging right now. I never knew someone could look so angry as they sleep. But I need to find a way to get into the lab! The best place to find reminders would probably be the corkboard.
~ viewtimes = viewtimes + 1
->office
- else:
->END
}