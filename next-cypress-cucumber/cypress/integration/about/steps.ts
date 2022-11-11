import { Given, When, Then } from 'cypress-cucumber-preprocessor/steps'	

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