Feature: Check page title

    Scenario: Verify the title of the Selenium homepage
        Given I have set up the Chrome driver
        When I navigate to the Selenium homepage
        Then the page title should be "Selenium"
