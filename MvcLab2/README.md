# Lab 2
Functional Requirements:
Given a list of Cars, you will need to implement 2 pages:
First Page:
1. Contains two different ways to list the cars
a. Using a table.
b. Using a list.
2. Each car entity should have (Manufacturer, Model, Image, HtmlDescription,
FirstUseDate)
3. Display the name of the cars as ({Model} From {Manufacturer}).
4. Display the usage duration (Seek for help for how to deal with DateTime).
5. Display the HtmlDescription as rendered Html not as plain text.
6. A button that redirects the user to a single element view.[Details]
7. Image should be rendered inside a figure tag and the alt attribute and the
figcaption tag should contain the name of the car ({Model} From {Manufacturer}).
Ex:
Second Page:
1. Details Page
2. Contains the details of the element and message to tell whether the user came
from a list or a table.
3. Button/Anchor To Return To Cars Page
Technical Requirements:
1. Reuse your code as much as possible and reduce duplicate code.
2. Use razor view engine features.
3. Use Render Methods.
4. Use query string parameters.
5. Use Tag Helpers.
6. Try to avoid editing model classes but use ViewModel if you need to add
property/method or need specific presentation to user ...etc.
Bonus:
Try to do your best and you’ll get a bonus on how much you achieved DRY
principle.
