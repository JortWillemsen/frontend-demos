Feature: App navigation

  Navigating the app using buttons and links.

  - The visiter can navigate the app using the buttons and links on the page.

  Scenario: Navigating to the about page
    Given I am on the home page
    When I click on the "about" link
    Then I see "about" in the url
    And I see "About Page" in the "h1"