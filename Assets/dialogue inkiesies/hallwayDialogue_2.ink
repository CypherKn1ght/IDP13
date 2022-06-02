# user has just become conscious after falling
VAR viewtimes = 0
->hallway
== hallway ==
{ viewtimes < 1:
You wake up with a horrible headache.
* [Continue]
Looking around, you notice that the platform is deformed in such a way that could only mean one thing: the platformed malfunctioned and knocked you out.
** [Continue]
'Wait, what time is it?'
*** [Continue]
'3:30 A.M?! You have to leave at 4:00. This promotion is too good to pass on, and there's no time to start worrying, so get up and start your mission: explore!
~ viewtimes = viewtimes + 1
->hallway
- else:
->END
}