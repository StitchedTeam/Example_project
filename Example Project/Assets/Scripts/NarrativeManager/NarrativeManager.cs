using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarrativeManager : Managers {

    [SerializeField] private NarrativeChapter currentChapter;
    [SerializeField] private Text chapterNumber;

    [SerializeField] private Text textDisplay;
    private int currentLine = 0;
    private bool textEnded = false;
    private bool textActive = false;

    /*[SerializeField] private Animator anim;
    private bool animationsEnded = false;*/

    /*private ParticleSystem partic;
    private Vector2 particpos;
    private bool particlesEnded = false;*/

    /*[SerializeField] private AudioSource audioPlayer;
    private bool audioEnded = false;*/

	void Start () {

        chapterNumber.text = currentChapter.name;

	}
	
	void Update ()
    {
        if (textEnded /*&& animationsEnded && particlesEnded && audioEnded*/)
        {
            if (currentChapter.nextChapter != null)
            {
                textEnded = false;
                print("End of chapter " + currentChapter.name + "'s text is set to " + textEnded.ToString());

                currentChapter = currentChapter.nextChapter;
                print("Current chapter is set from " + currentChapter.previousChapter.name + " to " + currentChapter.name);
                chapterNumber.text = currentChapter.name;


            }
        }
    }


    public void TextSequence()
    {

        if (!textEnded)
        {
            if (!textActive)
            {
                currentLine = 0;
                textDisplay.gameObject.SetActive(true);
                textActive = true;
                print("Text's display mode is set to " + textActive.ToString());
            }
        }

        if (currentLine >= currentChapter.textLines.Length)
        {
            textDisplay.gameObject.SetActive(false);
            textActive = false;
            print("Text's display mode is set to " + textActive.ToString());
            textEnded = true;
            print("End of chapter " + currentChapter.name + "'s text is set to " + textEnded.ToString());
        }

        if (currentLine < currentChapter.textLines.Length)
        {
            textDisplay.text = currentChapter.textLines.GetValue(currentLine).ToString();
            print("Displaying line " + currentLine.ToString());
            currentLine += 1;
        }


    }

}
