# C# Hair Salon Client Management System
## Created by Charles Emrich

### Description
A simple app for managing clients and stylists in a theoretical hair salon.

### Installation
1. Download or clone the repository from [here](https://github.com/CharlesEmrich/hair-salon-cs.git).
2. Using SSMS, or another program with similar functionality, the databases can be reconstructed by executing the .sql files found in Databases. In SSMS, that involves opening the file and selecting Execute Script... from the top button bar.
3. Start the app by running dnx run, or a similar local-server-starting command in your terminal of choice.
4. If debugging is necessary, the command "dnx test" is available.
5. Point your web browser to localhost:5004 to begin using the app.

### Specifications
| Behavior                                                  | Input                                | Output                                                      |
|-----------------------------------------------------------|--------------------------------------|-------------------------------------------------------------|
| User creates a stylist.                                   | Add 'John.'                          | Show view with John.                                        |
| User adds a client.                                       | Add 'Craig.'                         | Show view with Craig and his stylist.                       |
| User views a stylist.                                     | Clicks 'Jenny.'                      | Show view with Jenny and her clients.                       |
| User updates a client's name.                             | Change 'Jrge' to 'Jorge.'            | Show view with updated client.                              |
| User deletes a client.                                    | Clicks 'Delete' next to client name. | Show view with client absent, acknowledging their deletion. |

### Known Bugs
There are two tests in the testing suite which have unresolvable conflicts. Notes and comments have been left in the testing file to provide more context.

#### License
This project is licensed under the MIT License.
Copyright (c) 2017 Charles Emrich
