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
To run the program, ensure the correct NuGet package are installed. If the correct packages are not installed,
right click the project and select "Manage NuGet Packages". Navigate through the UI to install the correct packages, 
which are listed in the file `packages.config`.

If the project has been opened by its `.sln` file in Visual Studio, press the `Start` button on the
top navigation bar in Visual Studio to run the project.

To close the program, navigate to the left navigation bar in our system and click on the `Logout` button to 
gracefully exit the program.

## Data Usage and Entry
Book data is generated from a `.json` file located in our `data` folder, which contains metadata about
books in our system. Book data is automatically generated from this file and users do not need to worry about this.

Users can 'log in' to our system, but this window is more for visual purposes and will automatically 
close regardless of input: users can enter whatever information they wish to. 

Users can change their personal information in their settings page by clicking on the 'change?' button
editing their specific field, and then clicking on the button once more. Users can enter whatever fields they wish to
in their name, email, phone, address, and password fields. Users can edit the rest of the fields from a drop-down menu
for that specific field. 

## General workflow for our system
After users have loged into our system, users can either add books to their cart by clicking on books located in our 
Virtu Scrollers or our general book search. After they have done this, users click on their shopping carts so they can edit
the items in their carts or choose to check out their items. When users check out their items, users can either continue 
to browse for books or navigate to their items page to see their checked out items, wishlist, and other information about
their books. Users can then initiate the return process for returning their books here. 