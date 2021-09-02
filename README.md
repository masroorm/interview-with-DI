# Using dependancy inversion for trying out some of those interview questions
This is a base application with DI setup.

You can use this to start creating individual service to inject with the functionality that you need seperated

The starting class is called BeginInterviewService. The main method in this class is called StartInterviewQuestions().
In that class is where you'll add the logic you want to run. 

For the purpose of following SOLID, you'll need to create interfaces and service classes, and then initialize them in the Program class, and then inject them as you see fit in the BeginInterviewService class.