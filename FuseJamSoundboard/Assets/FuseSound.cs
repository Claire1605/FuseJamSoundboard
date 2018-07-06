using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(AudioSource))]
public class FuseSound : MonoBehaviour {
   
    public List<Button> buttons = new List<Button>();
    public List<KeyCode> keycodes = new List<KeyCode>();

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        for (int x = 0; x < keycodes.Count; x++)
        {
            if (Input.GetKeyDown(keycodes[x]))
            {
                buttons[x].Select();
                buttons[x].onClick.Invoke();
                Invoke("DeselectButton", 0.5f);
            }
        }
    }

    private void DeselectButton()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void fusionTimeLetsGo(AudioClip sound)
    {
        if (!audioSource.isPlaying)
            audioSource.PlayOneShot(sound);
    }
}
