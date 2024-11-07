# IDENTIFYING

## **Identifying a Need:** 

The problem that my game will address is the social norms of today's society, and how moral and ethical dilemmas have become blurred and warped in modern day society. The gameplay has the main idea that the player will go through various different scenarios, each faced with a dilemma, as they try to answer with their own philosophies and morals.   

**PROBLEM STATEMENT:** Player will learn about the issues within society, and how it may affect their decisions and impact on morals. 

**INPUTS:** Keyboard

**PROCESSING:** The game code will update the players position, and check to see if any new events have happened, each time the player makes an input on the keyboard or mouse.

**OUTPUTS:** The game will display stats on how the player did and what they have achieved throughout the game.

**TRANSMISSION:** The game should only need a network connection to start Unity. (NO MULTIPLAYER)

**STORAGE:** The game will store player info locally.



# FUNCTIONAL REQUIREMENTS

**USER INTERACTION:** 

The user will interact with the system via Unity, and using their keyboard to move the ingame character around, with other small gimmicks such as options and buttons. The expected "E" key will result in the response of the character interacting with nearby objects or NPC's, to talk with.

**CORE GAMEPLAY:**

The main actions or functions that the game will have will many include walking and a little bit of puzzle sovling, but will be more based on a story telling and engaging game where the player must talk with various NPC's. The way these mechanics will work is that as the player progresses through the game, they will be required to talk to the NPC's, and do puzzles to continually progress.

**SCORING AND FEEDBACK:**

The game will simply display stats when the player reaches the end of the game.

**SAVING AND LOADING DATA:**

The game will save progress via JSON files, locally.


# NON FUNCTIONAL REQUIREMENTS

**PERFORMANCE REQUIREMENTS:** 

The game should be able to load within a couple seconds, and the user inputs should be exact and precise

**USABILITY REQUIREMENTS:**

The game will have a beginner level where the player will go through all the core mechanics and have a taste at the gameplay style that they will experience.

**COMPATABILITY REQUIREMENTS:**

The device should be able to run unity hub, which is all that it should need to be able to run the game.

**SCALABILITY REQUIREMENTS**

The game should be able to handle several levels without having any issues with performance or lag.

**SECURITY REQUIREMENTS**

All data from the players should be saved locally, due it being a offline game, the game shouldn't require any important info from the player.

**RELIABILITY AND AVAILABILITY**

The game should be available for access to anyone due to the fact that is does not have any network requirements, seeing how it is an offline game, and that it should save progress with each checkpoint or level.

# CONSIDERATION OF SOCIAL AND ETHICAL ISSUES

## Defining
- **Equity**

The quality of being fair and impartial. (taken from google)
- **Accessibility**

The quality of being easy to obtain or use. (also taken from google)

**ACCESSIBILITY**

My project should be able to be used by most people, however to people that may have a disability issue the game my pose a issue, to the people with impaired vision. This will be solved via methods such as subtitles, bigger objects in the game, and nothing too minimalised to the point that people will start to have problems with seeing the game.

**PRIVACY AND DATA PROTECTION**

The game will store player info and data, shown in high scores and other achievements that the player will make through their playthrough of the game.

**FAIRNESS AND REPRESENTATION**

The game won't have any sterotypes, and will based on a simlistic characterrsr with no racial intent or ill thought. The main idea is that the game will actually explore a bit of this topic, regarding hte problems of our ccurrent day society.

**MENTAL AND EMOTIONAL WELL-BEING**

The game shouldn't trigger any mental health issues, but rather attempt to promote more thinking and consideration, avoiding content that might be too distressing and keeping things at a controlled level.

**CULTURAL SENSITIVITES**

The game content won't have any sterotypes, as it is only meant to be a text based story game, with puzzles, and interactions, meaning there wouldn't be a need for overly sterotypical characters.

| Existing Idea | Plus | Minus | Implication |
|---------------|------|-------|-------------|
| Beholder ![Beholder](/images/beholder.jpg)|The idea of Beholder is a well thought out one, where the player is forced to make tough moral decisions, by being the apartment owner, with the ability to go through the tenants belongings for anything that might harm the state, or they could side with the civillians and attempt to overthrow the state.|A idea that I don't think is sensible with Beholder is the fact that there isn't as much puzzles, but it still questions the morality of the player and the ethical decisions made in order of the "state".|I can use the way that this game utiliteses the surroundings of the player, in the dystopian state so that the player is forced into tough moral decisions, which I may implement into my game moving forward.             |
| Fallout 4 ![fallout4](/images/fallout4.jpeg)|Fallout is also a dystopian(?) post-apocolyptic game where the player gets thrust into unforgiving lands, forcing them to make moral or ethical decisions in order to survive, which has a final impact on the ending of the game, based on the immoral or moral decisions that you have made.|One idea I don't quite like about Fallout is the way that the immorality system works, making specific locations unreachable, or the story being altered due to the "karma" levels.| I can utilise the karma system in Fallout into my own game, but to a more lesser extent, to the point that it doesn't affect the core story of the game, but rather small events such as worse luck or more hostility, to make the player feel more pressured to make moral or immoral decisions.             |
| Undertale ![undetale](/images/undertale.png)|Undertale is a top down game, where the player falls into a "underground" world, having many options such as pacifist runs, or genocide runs to try and either stay in the world, or leave it through peace or violence, causing hte player to have to make many moral or immoral decision, weighing heavily on the final outcome of the game.|A negative part about Undertale is the overwhelmingly long amount of time that the player has to go through, and one mistake with progressing through the story may require the player to backtrack on nearly several hours of work.|I can take the way that Undertale is far too long to make my game shorter, not punsihing the player as heavily if they make a mistake and go the wrong way.             |

# PSEUDOCODE and FLOWCHARTS

## Pseudocodes.

**Basic movement of WASD and E key for interactions**
While game is running
    Check for user input
    Store user input in variable

While game is running
 
Check for user input 

Store user input in variable 

   If user input is "W" Move player up by movement speed

   Else if user input is "A" Move player left by movement speed 

   Else if user input is "S" Move player down by movement speed

   Else if user input is "D" Move player right by movement speed 

If user input is "E" Interact with object at player position 

  Update the game state 

  Render the game with player position

**Save and Load files (save)**
Function SaveFile (FileName, Content)

   Open file with name FileName in write mode 

   If file is opened successfully  

     Write Content into the file 

     Close the file 

Else 

    Print "Error opening file" 

  End If 

End Function

**Save and Load files (load)**
Function LoadFile(FileName)

    Open file with name FileName in read mode

    If file is opened successfully

        Read the content of the file into a variable

        Close the file

        Return the content

    Else

        Print "Error opening file"

        Return an empty value or error message

    End If

End Function

test










