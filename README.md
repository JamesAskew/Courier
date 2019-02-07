# Tasks
Each task was completed in a feature branch and merged into develop with a PR. To see a snapshot of the code for a specific task please review the [closed Pull Requests](https://github.com/JamesAskew/Courier/pulls?q=is%3Apr+is%3Aclosed).
Only tasks one to four have been completed. I ran out of time and didn't start on five.

# Courier.Api
This is the entry point for the calculations. It's created as a .net core web app as that was a convenient way to get framework code for dependency injection.
The Main calculation expects a list of parcel dimensions and weights. It will then return a wrapper object with the following properties:
- Prices (for each parcel)
- Total price for all the parcels in the order
- Speedy shipping price

# Courier.Api.Test
Test project for the calculations. This does not use a Mocking Framework. The nature of the test meant that the data was all essentially mocked anyway. I could see no benefit to adding a package like Moq. 
Not every edge case has been tested due to time constraints. The calculations are tested and to some degree the returned objects are tested.

# Courier.Domain
Contains classes and other reusable code. This project contains no business logic, just pocos. As such there is no test project associated with it. 

# Courier.Services
Contains three services which are responsible for the performing calculations on the inputted data: 
- SizeService - works out the correct size for a parcel based on dimensions
- PriceService - works out the correct price for an item
- OrderService - works out the entire order price

These services are based on their own interfaces and are injected in to the main calculation class in Courier.Api.

# Courier.Services.Test
Tests each of the services and their core functionality.

# Clarifications
In a real world environment I would have sought clarifiation on a few areas of the spec: 
- Clarification about the input type and the expected output.
- Speedy shipping should be listed as a seperate item. I wasn't sure what was expected of me here. I am confident my solution is not what's expected!

# Considerations
My tests became messy quite quickly. If I were to start again, I wouldn't have the Web Application class to group the logic. Or preferably I would expose a public API which could then be tested instead.
The solution I have delivered has duplicate test areas.
Some areas in the pricing service have become brittle with the later feature requests. This should be refactored. In hindsight a nicer approach would have been to return objects which could be passed around, rather than doing the calculations all in the service.
