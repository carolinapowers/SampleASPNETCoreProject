# SampleASPNETCoreProject
A sample project using ASP.NET Core and XUnit tests

# Running Tests

 - To run tests from terminal or command prompt type `dotnet test` (note: while you can run this from root, it runs faster if you direct it to the SampleXunitTestsProject folder)
 - To run tests locally as users will likely see it, open visual studio for OSX or Windows and click on "Run All Tests" in the UI.

# Modifications needed to run tests

 - Tests should run without any changes needed

# Steps for Testing Output

 - To have tests provide XML output use command `dotnet test --logger 'trx;LogFileName=results.xml` this will create test output in a `TestsResults` folder.
 - First run should fail two tests
    - `SampleViewTest.FailedTest` is the output we should expect when a test fails. (no errors, but assert fails)
    - `SampleModelTest.ExceptionTest` is the output we should expect when the learner does something that compiles but throws an error when tested.
 - To fix these tests (all passing)
    - Open the `Views\Sample\BreakStuff.cshtml` file and Delete the words "BreakStuff" from the file.
    - Open the `Models\SampleModel.cs` file and comment out line that calls `throw` in the `BreakStuff` method.
 - Testing Compiler Errors
    - Open the `Controllers\SampleController.cs` file and uncomment out the commented code in the `BreakStuff` action. _Note_ : once this is uncommented no tests can run successfully until it's commented out again. This is meant to give you the output needed to spot a compiler error and pass it on to the user.