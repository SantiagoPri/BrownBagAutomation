﻿Feature: wishlistpath
	Add an item after creating a wishlist for my sweet 16

@mytag
Scenario: Create a wishlist +1
	Given I'm logged in homepage
	And I click on view my customer account
	And click on wishlist
	When I create a wishlist
	And I go to dresses section
	And I select 'more' on a dress
	And I click on 'add to wishlist'
	Then the result should be 'Added to your wishlist'

	
	
	