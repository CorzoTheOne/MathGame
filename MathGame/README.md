# MathGame
My C# MathGame

Math game where you perform mathematics and try to get as high as possible. 
You can preselect starting levels - or start from 1 - and the game will increment the difficulty as you progress.

The game will have the following features
1. Scoreboard (memory only - no db)
2. Mulitple Levels
4. Ability to start a new game - while the scoreboard keeps track of the last 5 games and the highest score. 
5. Player naming 

Sequence:
Game opens at MainMenu.
- Console is cleared.
- Console requests user input
1. ViewPlayers
2. ViewScoreBoard
3. StartGame
4. Press 'q' to quit game

if (1) ViewPlayers
- Console is cleared 
- List of players appear
- Press 'q' to return to Main menu 

if (2) ViewScoreBoard
- Console is cleared 
- Scoreboard with last 5 games' scores
- All-time highscore is distinctively visible
- Press 'q' to return to Main menu 

if (3) StartGame
- Console is cleared
- Asks the player for a Name 
	. If name exists in "database" -> Select that player
	. Else if not -> Create a new player 
- Start a game (Play) with the player

