Feature: Image changes without saving

Scenario: Image changes without saving
	Given All existing open instances of the Paint are closed

	When I open Paint
	Then Application is open 

	When I open modal window Paste From, using the Paste option on the main application screen
	Then Modal window Paste From is open 

	When I upload 'minion1.jpg' using Modal window Paste From
		And I get the picture 'minion1.jpg' creation date
		And I open Image Properties
	Then Image Properties is open 

	When I set the units to 'Centimeters'
		And I enter width = '10'
		And I enter height = '10'
		And I click button OK in Image Properties 
	Then The size image has changed correctly - '10'x'10' 'cm'

	When I Click 'Resize' in the picture toolbar
	Then Modal window Resize and Skew is open 

	When I unselect checkbox 'Maintain aspect ratio'
		And I enter '50' in the field vertically
		And I click button OK in Resize and Skew modal window
	Then The size image has changed correctly - '10'x'5' 'cm'

	When I close Paint
	Then A dialog appeared with a proposal to save the results

	When I refuse to save the result
	Then The original picture 'minion1.jpg' has not changed