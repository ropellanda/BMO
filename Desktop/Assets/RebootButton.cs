using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebootButton : MonoBehaviour
{
    public TerminalController terminal;

    private void Start()
    {
        terminal = GameObject.FindGameObjectWithTag("Terminal").GetComponent<TerminalController>();    
    }

    public void startReboot()
    {
        terminal.shouldReboot = true;
    }
}
