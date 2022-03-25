
import java.util.ArrayList;

public class RSSService {
    private ArrayList<IObserver> observers;
    private ArrayList<Post> posts;

    public RSSService(){
        observers = new ArrayList<IObserver>();
        posts = new ArrayList<Post>();
    }

    public void registerObserver(IObserver observer){
        observers.add(observer);
    }

    public void removeObserver(IObserver observer){
        observers.remove(observer);
    }
    
    public ArrayList<Post> getPost(){
        return this.posts;
    }

    public void addPost(Post post){
        posts.add(post);
        notifyObservers(post);
    }

    public void notifyObservers(Post post){
        for(IObserver observer : observers){
            observer.update(post);
        }
    }
}
