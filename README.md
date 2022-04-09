# **CIS410GameProgramming-P2**
## **Operation**
1. Complete clone entire repository.
2. Use unity editor to build the corresponding game files for different platform, then run the game file (Don't support WebGL).  
## **Description of Assignment Requirements**
### 1. Dot Product
**Used:** In the "ChangeChaseSpeed"(used in "SpeedChange" GameObject under Ghost1 - Ghost4) script, detect the orientation of John lemon to ghost and the angle between them by dot product, then change chase speed of ghosts by the function IncreaseSpeed() and DecreaseSpeed() from script WaypointPatrol.  
**Trigger:** If John lemon in front of ghost and John lemon is within 25 degrees of ghost's field of vision (ignore distance), the speed of ghost will be double (As a balance of difficulty, shrunking ghost's capture distance, so now it's more like capturing the range than PointOfView).  
**The walls cannot block the view of ghosts**
### 2. Linear Interpolation
**Used:** In the DVDImage UI object. What's spookier that getting chased by ghosts? A DVD logo that hits the corner everytime! You can find this by going forward when you start the game, and you will see that
one of the two paintings in front of you is really spooky.  
**Implementation:** There is a world space canvas object that is the size of the painting on the wall, and this UI object have 4 children:
1. DVDImageBackground: Background for the DVDImage
2. DVDImage: UI Image that carries the DVD logo and have the Linear Interpolation script attachted to it. It goes back and forth between the the position of "LeftTop" and "BottomRight" game objects.
3. LeftTop: Empty game object to make the location marking easier for the Linear Interpolation code. 
4. BottomRight: Empty game object to make the location marking easier for the Linear Interpolation code. 
### 3. Particle Effect
**Used:** Ghosts have white particles surrounding them  
**Trigger:** Constant
## **Contributions**
Turan Bulut: Problem 3,5 of assignment.  
Nick Onofrei: Problem 4,5 of assignment.  
Haoran Zhang: Problem 1,2,5 of assignment.
####
## **Reference** 
https://learn.unity.com/project/john-lemon-s-haunted-jaunt-3d-beginner?uv=2020.3
## **Identifying Information**
**Authors:**  
Turan Bulut,  turanb@uoregon.edu  
Nick Onofrei, nonocifre@uoreogn.edu  
Haoran Zhang, hzhang9@uoregon.edu
