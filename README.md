## ArkanoidProject | Delachapelle Logan
This project is a breakout game inspired by the Arkanoid game, to train me as a junior developer.
## Configuration
**Player :**
- This script is used for player movement using the mouse so we must configure the sensitivity.
#
**SceneLoader :**
- This script manages the change the scene we must configure the name of our scene according to the levels.
#
**Scores :**
- This script manages the score and the high score, you just have to configure the texts to know where to display the scores.
#
**ResetPointInStart**
- Reset score in start game.
#
**PowerUpDamage/Score**
- These scripts are for the two power ups in the game, you just have to define the layer (the player's layer in number), then the delay is the duration of the power up's effect and finally the speed which is the speed at which it has descended.
#
**Games :**
- This script is used to go to the next level, you have to put the parent game object of all the bricks to know when you have to go to the next level.
#
**Brics :**
- This one manages the bricks so we have to configure their life, their point that they will give when they are destroyed and finally the two power up's in Prefabs.
#
**Ball :**
- This last script is used to move the ball so we have to configure the speed where the ball is going.