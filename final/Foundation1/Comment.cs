public class Comment {
    private string _commenterName;
    private string text;

    public string GetCommenterName() {
        return _commenterName;
    }

    public void SetCommenterName(string name) {
        _commenterName = name;
    }

    public string GetText() {
        return text;
    }

    public void SetText(string commentText) {
        text = commentText;
    }

    public Comment(string commenterName, string text) {
        SetCommenterName(commenterName);
        SetText(text);
    }
}