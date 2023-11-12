using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminalController : MonoBehaviour
{
    public GameObject[] terminalLog;

    public GameObject recoveryWindow;

    public bool shouldReboot = false;

    void Update()
    {
        if (shouldReboot == true)
        {
            recoveryWindow.SetActive(false);
            StartCoroutine(DownloadCoreDrivers());
        }
    }

    public IEnumerator DownloadCoreDrivers()
    {
        terminalLog[0].SetActive(true);
        yield return new WaitForSeconds(3);
        terminalLog[1].SetActive(true);
        yield return new WaitForSeconds(1);
        terminalLog[2].SetActive(true);
        yield return new WaitForSeconds(2);
        terminalLog[3].SetActive(true);
        yield return new WaitForSeconds(3);
        terminalLog[4].SetActive(true);
        yield return new WaitForSeconds(1);
        terminalLog[5].SetActive(true);
        yield return new WaitForSeconds(2);
        terminalLog[6].SetActive(true);
        yield return new WaitForSeconds(3);
        terminalLog[7].SetActive(true);
        yield return new WaitForSeconds(2);
        terminalLog[8].SetActive(true);
        yield return new WaitForSeconds(3);
        PlayerPrefs.SetInt("fixed", 0);
        SceneManager.LoadScene("Desktop");
    }
}