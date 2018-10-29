using UnityEngine;

public class HighlightController : MonoBehaviour {

    private HighlightObject highlightObject;

    public void SelectObject(HighlightObject highlightObject)
    {
        if(this.highlightObject != null)
        {
            this.highlightObject.StopHighlight();
        }

        this.highlightObject = highlightObject;
        this.highlightObject.StartHighlight();
    }

    
       

}
