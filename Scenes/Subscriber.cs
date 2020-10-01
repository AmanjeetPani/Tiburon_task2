using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ROSBridgeLib;
using SimpleJSON;
using ROSBridgeLib.std_msgs;

public class Subscriber : ROSBridgeSubscriber
{
  static GameObject player;
  public static Rigidbody rb;
  
  // These two are important
  public static string GetMessageTopic() {
    //Topic name is up to the user. It should return the full path to the topic. 
    //For eg, "/turtle1/cmd_vel" instead of "/cmd_vel".
    return "/chatter";
  }

  public static string GetMessageType() { 
    //Same as the definition present in ROS documentation:
    return "std_msgs/Float64";
  }

  // Important function (I think.. Converts json to PoseMsg)
  public static ROSBridgeMsg ParseMessage(JSONNode msg) {
    return new Float64Msg(msg);
  }

  // This function should fire on each received ros message
  public static void CallBack(ROSBridgeMsg msg1) {
    
    Float64Msg msg = (Float64Msg)msg1;
    Debug.Log("Recieved Message : "+msg.GetData());
    // Update ball position, or whatever
    player = GameObject.Find("Player");
    rb = player.GetComponent<Rigidbody>();
    if(msg.GetData() == 8)
	rb.AddForce(new Vector3(0, 0, 500));
    if(msg.GetData() == 6)
	rb.AddForce(new Vector3(500, 0, 0));
    if(msg.GetData() == 4)
	rb.AddForce(new Vector3(-500, 0, 0));
    if(msg.GetData() == 2)
	rb.AddForce(new Vector3(0, 0, -500));
    if(msg.GetData() == 5)
	rb.AddForce(new Vector3(0, 500, 0));
  }
}
