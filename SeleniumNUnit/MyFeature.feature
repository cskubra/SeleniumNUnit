Feature: MyFeature

A short summary of the feature

@tag1
Scenario: Amazon Test
	Given User navigates to url "https://amazon.com"
	When User input text "selenium test" on "//input[@id='twotabsearchtextbox']"
	When User clicks on "//input[@type='submit']"
	When User clicks on "//span[text()='Test Automation using Selenium WebDriver with Java: Step by Step Guide']"
	Then User verify value of "//span[@xpath='1']" is "$28.60"
	Then User closes the browser
	