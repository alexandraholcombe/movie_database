# NOT IMDB

#### _Internet Movie Database that is not IMDB_

#### By _**Alexandra Holcombe && Sam Kirsch**_

## Description

This website will let users enter and save movies along with affiliated actors and characters.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The user can add a movie to the movies list in the database**
* Example Input: "Fight Club"
* Example Output: "Fight Club"

**The user can add an actor to the actors list in the database**
* Example Input: "Brad Pitt"
* Example Output: "Brad Pitt"

**The user can add a character to the characters list in the database**
* Example Input: "Tyler Durden"
* Example Output: "Tyler Durden"

**The user can use a form to add a movie along with the main actor and role**
* Example Input: "Fight Club, Brad Pitt, Tyler Durden"
* Example Output: "Movie: Fight Club, Actor: Brad Pitt, Character: Tyler Durden"

**The user can add multiple actor-role pairs per movie**
* Example Input: "Brad Pitt, Tyler Durden" "Edward Norton, The Narrator"
* Example Output: "Movie: Fight Club, Actor: Brad Pitt, Role: Tyler Durden, Actor: Edward Norton, Role: The Narrator"


## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Sam Kirsch at dontemailme@dontemailme.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe && Sam Kirsch_**
