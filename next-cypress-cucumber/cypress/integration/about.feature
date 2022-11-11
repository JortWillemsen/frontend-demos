Feature: App

  Scenario: Navigating to the about page
    Given I am on the home page
    When I click on the "about" link
    Then I see "about" in the url
    And I see "About Page" in the "h1"