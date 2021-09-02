# Using dependancy inversion for trying out some of those interview questions
This is a base application with DI setup.

You can use this to start creating individual services which can be injected with the required functionality.

The starting class is called BeginApplicationService. The main method in this class is called StartApplication().
Inside that class is where you'll add the logic you want to run. 

For the purpose of following SOLID, you'll need to create interfaces and service classes, and then initialize them in the Program class, and then inject them as you see fit in the BeginInterviewService class.