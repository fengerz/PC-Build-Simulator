using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject victoryScreen;
    public AudioSource victorySound;

    //Motherboard components
    private bool cpu_in_mb = false;
    private bool ram_in_mb = false;
    private bool fan_in_mb = false;
    private bool gpu_in_mb = false;

    //Case components
    private bool mb_in_case = false;
    private bool ps_in_case = false;
    private bool ssd_in_case = false;
    private bool fs_in_case = false;

    public bool CPU_in_MB {
        get {return cpu_in_mb;}
        set {cpu_in_mb = value;}
    }

    public bool RAM_in_MB {
        get {return ram_in_mb;}
        set {ram_in_mb = value;}
    }

    public bool Fan_in_MB {
        get {return fan_in_mb;}
        set {fan_in_mb = value;}
    }

    public bool GPU_in_MB {
        get {return gpu_in_mb;}
        set {gpu_in_mb = value;}
    }

    public bool MB_in_Case {
        get {return mb_in_case;}
        set {mb_in_case = value;}
    }

    public bool PS_in_Case {
        get {return ps_in_case;}
        set {ps_in_case = value;}
    }

    public bool SSD_in_Case {
        get {return ssd_in_case;}
        set {ssd_in_case = value;}
    }

    public bool FS_in_Case {
        get {return fs_in_case;}
        set {fs_in_case = value;}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Start() {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer() {
        while (true) {
            yield return new WaitForSeconds(5);
            //Debug.Log("CPU-"+CPU_in_MB + "; RAM-"+ RAM_in_MB + "; Fan-" + Fan_in_MB + "; GPU-" + GPU_in_MB + 
            //"; MB-" + MB_in_Case + "; PS-" + PS_in_Case + "; SSD-" + SSD_in_Case + "; FS-" + FS_in_Case);
            if (CPU_in_MB && RAM_in_MB && Fan_in_MB && GPU_in_MB && MB_in_Case && PS_in_Case && SSD_in_Case && FS_in_Case) {
                victoryScreen.SetActive(true);
                //victorySound.Play();
            }
        }
    }
}
