Feature: Check if a vehicle exists using the dealer portal

Background: 
Given I'm on the dealer portal "https://covercheck.vwfsinsuranceportal.co.uk/"

Scenario Outline: Enter a registration number that exists in the system
When I enter a valid "<Registration Number>" that is present in the system
Then I should be able to see the details of the vehicle
Examples:
|Registration Number|
|OV12UYY|
|OV 12UYY|
|ov12 uyy|


Scenario Outline: Enter a registration number that does not exist in the system
When I enter a  valid "<Registration Number>" that is not present in the system
Then "Sorry record not found" message should appear
Examples:
|Registration Number|
|12345678|
|OV12UYZ|
|ov12 uyu|

Scenario Outline: Enter an invalid registration number
When I enter an invalid "<Registration Number>"
Then "Please enter a valid car registration" error should appear
Examples:
| Registration Number |
|                     |
| OV1,2UYY            |
| OV.12UYY            |
| ov12!uyy            |
| 12.34               |



