using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Connection : MonoBehaviour {
    OSC osc;
    public float pxPos;
    public float pyPos;
    public float pRotation;

    // Start is called before the first frame update
    void Start() {
        osc = GetComponent<OSC>();
    }

    // Update is called once per frame
    void Update() {
        // server = new UdpClient(PORT);

        // remote = new IPEndPoint(IPAddress.Any, PORT);
        // var data = server.Receive(ref remote);
        // Debug.Log(data);
        // server.Send(new byte[] {1}, 1);
        // OscMessage msg = new OscMessage();
        // msg.address="/test";
        // msg.values.Add(Input.mousePosition.x);
        // msg.values.Add(Input.mousePosition.y);
        // osc.Send(msg);

        // msg = new OscMessage();
        // msg.address = "/owo";
        // msg.values.Add(1);
        // osc.Send(msg);
        ArrayList playerLst = new ArrayList();
        playerLst.Add(pxPos);
        playerLst.Add(pyPos);
        playerLst.Add(pRotation);
        SendMessage("player", playerLst);
    }
    public void SendMessage(string obj, ArrayList values) {
        OscMessage msg = new OscMessage();
        msg.address = "/" + obj;
        msg.values = values;
        osc.Send(msg);
    }
    // public void Reset(int id) {
    //     OscMessage msg = new OscMessage();
    //     msg.address = "/" + id.ToString();
    //     msg.values.Add(-1);
    //     for (int i = 0; i < 12; i++) { // 12 is just a random number
    //         msg.values.Add(0);
    //     }
    //     osc.Send(msg);
    // }

    // void OnApplicationQuit() {
    //     Debug.Log("QUIT");
    //     for (int i = 0; i < 10; i++) {
    //         Reset(i);
    //     }
    // }
}
