import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given ("I am on the home page", () => {
  cy.visit('http://localhost:3000')
});

Given ('I open the about page', () => {
  cy.visit('/about');
});

When ('I click on the {string} link', (link) => {
  cy.get(`a[href="/${link}"]`).click();
});

Then ('I see {string} in the url', (path) => {
  cy.url().should('include', path);
});

Then ('I see {string} in the title', (title) => {
  cy.title().should('include', title);
});

Then ('I see {string} in the {string}', (text: string, element: string) => {
  cy.get(element).contains(text);
});
