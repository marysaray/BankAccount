# Bank Account Unit Testing Sample
## Automated Code Testing

**Implementing and Learning the process of Test-Driven Development*

  **How do we determine if our code works?**
  - Lots of manual testing
  - Very easy to miss our own logic errors
  - Our team members might change our code, or we might change our minds down the road
  
  **Unit test allow us to write code to test existing code**
  - Run automatically on build 
  - Will fail if a change is made that breaks our existing test (instant notification)
  
  **No guarantee that our code is correct**
  - Tests can easily be wrong
  - Tests need to be maintained
  
  ## Test-Driven Development

  **TDD starts by writing the tests:**
  
  - Then code is written to make the tests pass
  - Write enough code for compilation, then make test pass

  **Red, Green Refactor motto:**
  
  - Red: Create a test (it will fail)
  - Green: Make the test pass by any means necessay (write some code)
  - Refactor: Standard refactoring, clean up your code! (Reduce redundancy)
  
  **Write only necessary code*
    
 ## Tests
 - Used to test public code
  - Can test protected and private code as well
 - Attributes are used to mark up our code
  - [TestClass]
  - [TestMethod]
  - ExpectedException, TestCategory, Priority, TestInitialize, and more
 - Tests are kept in a separate project
 
  **May need to run Visual Studio as administrator*
 ## Basic Steps
  - Create a unit test project
  - Create a test class and write test methods to ensure code works as expected
  - Assert class is used to test values 
    - Ex. test if an expected value is returned from a method    
    - Either passes or fails, each test should only test one logical thing
    - Test can also throw expected exceptions
    
  ## Good Tests
    - Descriptive names
    - Repeatable
    - Not fragile
    
  ## Real World
  - Tests are the best, most efficient way, to make sure new code does not break
    existing behavior and behaves as expected
  - Running tests can be set up as part of each check-in
    - If somebody breaks the build, they can fix it
    - Tests aren't run locally ("it works on my machine")
  - This process can be automated with source control
