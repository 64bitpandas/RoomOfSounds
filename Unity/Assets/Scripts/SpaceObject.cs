using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceObject : MonoBehaviour
{
    public string objName;
    Connection connection;
    // Start is called before the first frame update
    void Start()
    {
        connection = GameObject.FindObjectOfType<Connection>();
    }

    // Update is called once per frame
    void Update()
    {
        ArrayList toSend = new ArrayList();
        toSend.Add(transform.position.x);
        toSend.Add(transform.position.z);
        connection.SendMessage(objName, toSend);
    }
}
