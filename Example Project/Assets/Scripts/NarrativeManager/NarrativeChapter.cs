using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Chapter")]

public class NarrativeChapter : ScriptableObject
{
    public string[] textLines;
    public Animation[] animations;
    public ParticleSystem[] particles;
    public Vector2[] particlesPosition;
    public AudioClip[] sfx;

    public NarrativeChapter previousChapter;
    public NarrativeChapter nextChapter;
}
