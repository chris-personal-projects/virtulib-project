# CPSC 481 Winter 2022 Group 17 Project: Virtulib

## Group Members
- Chris Chen
- Kirill Larshin
- Keaton Banik
- Zelin Zhou

## Project Overview
Virtulib is an online library catered to bringing the browsing experience of in-person libraries to the 
comfort of your own home. Books and other items that can be ordered with our system are then delivered 
to your home for your convenience. Users then ship back books they must return with the help of our system.

## Disclaimer
This project has a focus on implementing user interactions and experiences (UI/UX) and does not include interactions with an online service, databases, or an actual library service.

## Cases and Functions Implemented
The following features were added to our project:

- Item search
- Item browsing with recommendations 
- Item checkout
- Item returns and shipping
- Item checkout notification
- Online virtual help and self-help
- Shopping cart 
- Account settings
- Checked out items dashboard

## Running the program
This project was developed with Microsoft Visual Studio and has a focus on running the program using the IDE's debugger.

To run the program, ensure the correct NuGet packages are installed. If the correct packages are not installed, inside Visual Studio, right click the project and select "Manage NuGet Packages". Navigate through the UI to install the correct packages, which are listed in the file `packages.config`.

If the project has been opened by its `.sln` file in Visual Studio, press the `Start` button on the
top navigation bar in Visual Studio to run the project.

To close the program, navigate to the left navigation bar in our system and click on the `Logout` button to 
gracefully exit the program.

## Data Usage and Entry
Book data has been randomly generated and scrapped from the [Open Library API](https://openlibrary.org/developers/api) using a Python script. The data has been serialized and placed into a `.json` file located in the `data` folder.

Users can 'log in' to our system, but this experience is simulated for visual purposes and automatically closes when form data is submitted.

Similarly, users can change their personal information in their settings page by clicking on the `change` button to
edit fields selected from a drop-down menu.

## General workflow for our system
After users have logged into our system, users can either add books to their cart by clicking on books located in our Virtu Scrollers interface or from our general book search.

After they have done this, users can select their shopping carts so they can edit the items in their carts or choose to check out their items.

When users check out their items, users can either continue to browse for books or navigate to their items page to view their checked out items, wishlist, and other information about their books. Users can then initiate the return process for returning their books here.