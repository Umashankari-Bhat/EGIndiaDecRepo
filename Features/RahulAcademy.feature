@Sprint2
Feature: Lab1 practice

  A short summary of the feature:
  This feature tests that the form is completed correctly and reaches the submit button but does not click it.

  @tag1
  Scenario: Verify form completion without clicking submit
    Given User is on the registration page
    When User enters "<name>", "<email>", and "<password>" in the text fields
    And User selects "<gender>" as gender
    And User chooses "<employmentStatus>" using the radio button
    And User selects "<dateOfBirth>" as date of birth
    Then The submit button should be enabled but not clicked

    Examples:
      | name        | email             | password  | gender  | employmentStatus | dateOfBirth |
      | kumar       | kumar@gmail.com  | pass123   | Male    | Employed         | 1990-01-01  |
      | smitha      |smith@gmail.com   | securePwd | female  | Student          | 1995-05-15  |
