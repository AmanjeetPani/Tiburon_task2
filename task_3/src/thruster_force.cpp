#include "ros/ros.h"
#include "std_msgs/Float64.h"
#include <sstream>
#include <iostream>

int main(int argc, char **argv)
{
  ros::init(argc, argv, "thruster_force");

  ros::NodeHandle n;
  ros::Publisher chatter_pub = n.advertise<std_msgs::Float64>("/chatter", 1000);
  
  ros::Rate loop_rate(10);

  std_msgs::Float64 num;
  int choice;

  std::cout<<"8 - move forward\n6 - move right\n4 - move left\n2 - move back\n5 - Jump\n";

  while (ros::ok())
  { 
    std::cout<<"Enter Your Choice : ";
    std::cin>>choice;  
    if (choice == 8 || choice == 6 || choice == 4 || choice == 2 || choice == 5)
    {
	    num.data = choice;
	    ROS_INFO("Published: %f", num.data);
	    chatter_pub.publish(num);
    }
    else
    	std::cout<<"Wrong Choice!!!\n";
    
    ros::spinOnce();
    loop_rate.sleep();
  }
  return 0;
}
