# NorthStandard QA Automation Exercise

This project is a **SpecFlow** and **NUnit**-based Selenium automation framework. It verifies the Selenium homepage's page title using a browser automation test written in C#.

---

## **Project Overview**

- **Framework**: SpecFlow (Behavior-Driven Development)
- **Unit Test Runner**: NUnit
- **Browser Automation Tool**: Selenium WebDriver
- **Language**: C#  
- **IDE**: Visual Studio

The automation script performs the following steps:

1. Sets up the ChromeDriver.
2. Maximizes the browser window.
3. Navigates to the [Selenium homepage](https://www.selenium.dev).
4. Verifies that the page title matches the expected value.

---

## **Project Structure**

The project follows the **Page Object Model** design pattern, making the code cleaner and more maintainable.

### **Key Files**

1. **Step Definitions**:
   - `CheckPageTitleSteps.cs`: Contains test steps (Given, When, Then) written in SpecFlow.

2. **Page Object**:
   - `SeleniumHomePage.cs`: Encapsulates all actions performed on the Selenium homepage.

3. **Feature File**:
   - `CheckPageTitle.feature`: A human-readable test script written in Gherkin syntax.

4. **Configuration**:
   - `specflow.json`: SpecFlow configuration for NUnit integration.

---

## **Requirements**

- **Visual Studio** (latest version)
- **.NET 6 or above** installed
- **NuGet Packages**:
   - SpecFlow
   - SpecFlow.NUnit
   - SpecFlow.Tools.MsBuild.Generation
   - Selenium.WebDriver
   - NUnit
   - NUnit3TestAdapter
- **Chrome Browser** (latest version)
- **ChromeDriver** (should match Chrome browser version)

---

## **Installation and Setup**

1. Clone the repository:

   git clone  https://github.com/Levisbrisibeo1/NorthStandard_QA_Exercise.git
   cd NorthStandard_QA_Exercise
   
   
Open the project in Visual Studio.

Install the required NuGet packages:

Run the following commands in the Package Manager Console:

Install-Package SpecFlow -Version 3.9.74
Install-Package SpecFlow.NUnit -Version 3.9.74
Install-Package SpecFlow.Tools.MsBuild.Generation -Version 3.9.74
Install-Package Selenium.WebDriver
Install-Package NUnit
Install-Package NUnit3TestAdapter


How to Run the Tests
Build the solution:
Go to Build → Rebuild Solution.

Open the Test Explorer in Visual Studio:
Go to Test -> Test Explorer.

Run the tests:

Locate the test scenario under Test Explorer.
Right click and select Run.