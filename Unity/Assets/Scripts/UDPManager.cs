using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class UDPManager : MonoBehaviour {

    private float lastSentDist;
    [SerializeField]
    private Goal goal;
    [SerializeField]
    private const float THRESHOLD = 0.05f;
    [SerializeField]
    private string IP;
    [SerializeField]
    private int port;

    // "connection" things
    IPEndPoint remoteEndPoint;
    UdpClient client;

    // Use this for initialization
    void Start () {
        lastSentDist = goal.GetDistance();

        remoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);
        client = new UdpClient();

        // status
        print("Sending to " + IP + " : " + port);
    }
    // Update is called once per frame
    void Update () {
		if(Math.Abs(goal.GetDistance() - lastSentDist) > THRESHOLD)
        {
            SendString(goal.GetDistance().ToString());
        }
	}

    // a funtion to send data via UDP
    private void SendString(string message)
    {
        try
        {


            // encode string to UTF8-coded bytes
            byte[] data = Encoding.UTF8.GetBytes(message);

            // send the data
            client.Send(data, data.Length, remoteEndPoint);

        }
        catch (Exception err)
        {
            print(err.ToString());
        }
    }
}
