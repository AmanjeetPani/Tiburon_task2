# Tiburon_task2
Tiburon task for ROS - Unity integration to move a player using number keys. </br>

Steps to run the project :</br>
1. Clone or download the repository to your device. </br>
2. Copy the **ROSBridgeLib** and **Scenes** folder into your local unity assets folder. </br>
3. Copy the **task_3** package into the src folder of your catkin_ws folder. </br>
4. Open your terminal and build the package using **catkin build** command. </br>
5. Launch roscore in your terminal followed by rosbridge websocket. </br>
6. Open your Unity screen and hit the play button. </br>
7. Open a new terminal window and give the command **rosrun task_3 thruster_force**. </br>
8. Press any numeric key as per the choice provided to move the player in the unity play screen. </br>
