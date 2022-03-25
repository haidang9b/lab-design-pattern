import java.util.ArrayList;
import java.util.Date;

public class RSSService{
    private Date lastUpdate;
    private ArrayList<Post> posts;

    public RSSService(){
        posts = new ArrayList<Post>();
        lastUpdate = new Date();
    }

    public ArrayList<Post> getPost(){
        return this.posts;
    }

    public void addPost(Post post){
        posts.add(post);
        lastUpdate = new Date();
    }

    public boolean hasNewPost(Date dt){
        if(lastUpdate.compareTo(dt) > 0){
            return true;
        }
        return false;
    }
}