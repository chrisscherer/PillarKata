A code kata from: https://gist.github.com/jameskbride/5482722

Done in c# and nUnit using MonoDevelop as an IDE, with a TDD approach.

Comments/Observations: 

I'm having trouble understanding when the best time to refactor code is. In the example video they do MVP to get the current test to pass, then write a new one and refactor old code if it needs it to pass the new test.

This makes sense to a point, but I struggle to see the point of this in the case of something simple like knowing you should print out the input instead of a fixed number.

Should tests themselves ever be refactored? It seems like it would be unavoidable since you never quite know what form your code will take... an example of this is when I decided it would be easier to validate times after midnight if they had 2400 added to them, instead of a bunch of if statements checking to see if they were in acceptable bounds. This seems to violate the idea of TDD though, since it was a change that wasn't strictly needed. 

Is it ok to refactor outside of a new test, if you see a better way to do something or anticipate a problem?

How do you handle those moments when you foresee a problem? For example, I started out wanting to use a string to return a more informative invalid input response, but this quickly turned into a bad idea as comparing this string values would require many int.ParseInt checks. Should I have written tests to move me in the direction of using ints, or is it an acceptable choice to acknowledge the shortcoming of my current methodology and change course without writing new tests and refactoring the current/old ones?

It would probably help to have a pair programmer and a better understanding of TDD but I'm also struggling with what exactly constitutes the minimum amount of code needed to pass a test. I'm sure some of these solutions could be simpler, but I can't think of a way to implement some code sections simpler without them being useless. For example, when calculating bedTime to midnight pay, I used a ternary statement to handle the case that endTime was before midnight. Should this have been a separate test, and I should have just tested with an end time after midnight? If so, what's the point of writing tests for requirements you know are going to be an issue. 

I also noticed a while ago that I've made this whole problem far more complicated than it needed to be by using separate methods in a class. This whole Kata probably should have been a single calculate pay method that took in the times as variables... Oh well, I might try redoing the kata and attaching a link so I have this practice attempt and then a more sensible approach...

After finishing most of the functionality barring finding a bug, I'm wondering if I should still go back and test every edge case I can think of. So far I've added two or three tests after the last one I managed to get red checking for edge cases and they all are green from the start. Does this mean I'm done or that I over engineered it in earlier tests and shouldn't have certain bits functioning?

Just about done. There are definitely some flaws in the way I did this. That being said I could refactor it into a much better use scenario, making start, end, and bed times variables in the calculate pay method. While this makes sense, does it make sense in a TDD context? If so, how do I go about refactoring out tests that were checking the results of earlier methods?

Looking at this I'm wondering if TDD is entirely compatible with OOP. It would make sense to break some of this out into more methods (Like calculating each pay period) but if I'm just going to MVP this doesn't make sense. So is this left to refactoring outside of a testing context, or just ignored until it becomes a problem. I'm probably going to do some reading on TDD because I think my biggest struggle is just with some of the implications of TDD in programming.

My overall experience was a pleasant one, I think TDD really had me take a hard look at my typical thought process while programming and helped me see some flaws in my typical approach and made it easy to spot flaws in previous parts of the code as I continued testing. I think with continued practice I will become much more proficient at writing tests, and more importantly knowing WHAT to test and look forward to a continuing exploration of TDD.