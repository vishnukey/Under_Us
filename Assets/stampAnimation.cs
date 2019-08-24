using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stampAnimation : MonoBehaviour
{
    public List<Frame> frames = new List<Frame>();
    int frameCount = 0;
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Projector>().material;
        StartCoroutine(Animate());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Animate()
    {
        while (true)
        {
            Frame frame = frames[frameCount % frames.Count];
            material.SetTexture("_ShadowTex", frame.texture);
            frameCount++;
            yield return new WaitForSeconds(0.001f * frame.delay);
        }
    }

    [System.Serializable]
    public struct Frame
    {
        public float delay;
        public Texture texture;
    }
}
