Feature: This test suite contains test scenarios for Profile Page Language feature


Scenario:A.Delete an existing Language
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Language tab 'language'
When User deletes all the records
Then User should not be able to view the deleted language record

Scenario Outline: B.Add a New Language
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Language tab 'language'
When User adds a new language record <language> <level>
Then Mars portal should save the new language record <language>

Examples: 
|language    |    level              |
| 'Spanish'  |    'Basic'            |
| 'Arabic'   |    'Conversational'   |
| 'French'   |    'Fluent'           |
| 'Chinese'  |    'Native/Bilingual' |

Scenario Outline:C.Update an existing Language
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Language tab 'language'
When User edits an existing language record <oldlanguage> <oldlevel> <newlanguage> <newlevel>
Then Mars portal should save the updated language record <newlanguage> <newlevel>


Examples: 
| oldlanguage | oldlevel            | newlanguage  | newlevel           |
| 'Spanish'    | 'Basic'            | 'Hindi'      | 'Conversational'   |
| 'Arabic'     | 'Conversational'   | 'Arabic'     | 'Fluent'           |
| 'French'     | 'Fluent'           | 'Malayalam'  | 'Fluent'           |
#| 'Chinese'    | 'Native/Bilingual' | 'Chinese'    | 'Native/Bilingual' |



