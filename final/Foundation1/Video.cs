public class Video {
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public string GetTitle() {
        return _title;
    }

    public void SetTitle(string videoTitle) {
        _title = videoTitle;
    }

     public string GetAuthor() {
        return _author;
    }

    public void SetAuthor(string videoAuthor) {
        _author = videoAuthor;
    }

    public int GetLengthInSeconds() {
        return _lengthInSeconds;
    }

    public void SetLengthInSeconds(int videoLengthInSeconds) {
        _lengthInSeconds = videoLengthInSeconds;
    }

    public Video(string title, string author, int lengthInSeconds) {
        SetTitle(title);
        SetAuthor(author);
        SetLengthInSeconds(lengthInSeconds);
        _comments = new List<Comment>(); 
    }

    public void AddComment(string commenterName, string text) {
        Comment newComment = new Comment(commenterName, text);
        _comments.Add(newComment);
    }

    public int GetNumberOfComments() {
        return _comments.Count;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Length: {GetLengthInSeconds()} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in _comments) {
            Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
        }
        Console.WriteLine();
    }
}