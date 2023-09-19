# Sixsentix Assessment
Automated test cases from the QA Assessment.

- This solution demonstrates automated testing of web pages with Selenium Webdriver, NUnit, C#.NET, and Extent Reports.
- Three tests are included that run tests on the demo website Luma available at https://magento.softwaretestingboard.com.
- The tests are structured according to the Page Object Pattern.
- The reports are stored in the directory C:\Reports\ under the name AutomationReport.html. The folder is created if it does not exist.
- The tests can be executed on Chrome.

# HOW TO RUN THE TESTS
# Option 1: using the DOTNET TEST command (https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test)
1. Download the solution from the MASTER branch.
2. Download the Chromedriver (https://chromedriver.chromium.org/downloads) and put it in the solution directory.
3. Build the solution. 
4. Open the command prompt.
5. Write the following command: dontnet test [SixsentixAutomation.dll PATH] (write the path to the DLL generated when building).
   For example: C:\Users\lucas>dotnet test "C:\Users\lucas\source\repos\SixsentixAutomation\SixsentixAutomation\bin\Debug\net6.0\SixsentixAutomation.dll"
6. Test will run and a summary will be displayed when finished.

![image](https://github.com/lucasruben/SixsentixAssessment/assets/18044146/cb4e9b64-41cd-484a-8aa9-c6074a4d5d18)

# Option 2: from Visual Studio
1. Download the solution from the MASTER branch.
2. Download the Chromedriver (https://chromedriver.chromium.org/downloads) and put it in the solution directory.
3. Build the solution. 
4. Go to the top menu and click on Test > Test Explorer.
5. A list of the available tests will be displayed.
6. Right-click any of them and click Run Test.
7. Tests will run and a summary will be displayed when done.

![image](https://github.com/lucasruben/SixsentixAssessment/assets/18044146/212a84fc-5e85-4da0-98a4-6f4183f4d7f0)

# Option 3: using the NUnit console (https://nunit.org/download/)
1. Download the NUnit Console.
2. Install it.
3. Open a command prompt.
4. Write the following command: NUNIT3-CONSOLE [SixsentixAutomation.dll PATH] (write the path to the DLL generated when building).
   For more information please go to https://docs.nunit.org/articles/nunit/running-tests/Console-Command-Line.html

