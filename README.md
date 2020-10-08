# Tiburon_task2
Tiburon task for ROS - Unity integration to move a player using number keys </br>Steps to run the project :













1:import the unity package into the unity editor can be done in two ways:> a: double clicking the unity package and it will automatically import into the current active unity projectt. b:by goin intothe unity projet and then importing it using import custom packages in the option and selecting the package there. 2:download the catkin_ws 3:launch roscore; 4: launch rosbridge websocket 5: rosrun beginner_tutorials unity 6: click on the play button in the unity project( before doing this make sure the previous steps are done) 6:type the appropriate commands for movement


copy the unity folder Unity Project task 1 folder into your unity scene. Then open the terminal and print the rosbridge connection command-"roslaunch rosbridge_server rosbridge_websocket.launch". then open another terminal and inititate the Thrusterforce.ccp script located in src/beginner_tutorials/src/Thrusterforce.cpp To run the Thrusterforce script- $ cd catkin_ws (Go to the root where you have copied the src folder) $ catkin_make $ source ./devel/setup.bash $ rosrun beginner_tutorials Thrusterforce run the Thrusterforce.cpp. Not go back to unity window and play the scene. Now using Thrusterforce give the values to the 3D object for its movement. You will see the respective print statements in the unity console.
