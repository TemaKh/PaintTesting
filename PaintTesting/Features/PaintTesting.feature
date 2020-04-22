Feature: Download any image. Refuse to save result.

Scenario: Download any image. Refusal to save result
	Given All existing open instances of the Paint are closed

	When I open Paint
	Then Application is open 

	When I open modal window Opening From, using the File tab on the main application screen
	Then Modal window Opening From is open

	When I upload 'minion1.jpg' using Modal window Opening From
		And I get the picture 'minion1.jpg' creation date
		And I click Select All
		And I Click 'Cut' in the toolbar clipboard
		And I close Paint
	Then A dialog appeared with a proposal to save the results

	When I refuse to save the result
	Then The original picture 'minion1.jpg' has not changed