CI/CD Sample Application
========================

We'll use this sample project in the [CI/CD on the Microsoft Stack](https://github.com/robrich/CICD-on-Microsoft-Stack-Workshop) workshop to build up a CI/CD pipeline.

This project is just a new ASP.NET MVC website using .NET 4.5.2 with OctoPack NuGet package, and a companion unit test project switched to use XUnit.


Steps to build this Sample Project
----------------------------------

1. File -> New Project

2. ASP.NET Web Application (not core)

3. MVC project template

4. Authentication to No Authentication

5. Add Unit Tests

6. Add these NuGet packages:

  - xunit - the test library
  - xunit.runner.visualstudio - for the Test Explorer window in VS
  - xunit.runner.console - to run tests from the command line
  - FluentAssertions - asserts read like sentances
  - OctoPack - used by Octopus Deploy to build assets

7. Change Home Controller Tests to use XUnit instead of MSTest

8. Commit this to a local git repository.
