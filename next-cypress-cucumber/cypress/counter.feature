Feature: Counter can be modified

    The counter can go up to 9999, and can be modified by the user.

    - The counter cannot go below 0.
    - The counter cannot be upped by more than 1 at a time.
    - The counter cannot be lowered by more than 1 at a time.

    Scenario: The counter is upped by 1
      Given The counter is 0
      When I up the counter 1
      Then The counter should be 1