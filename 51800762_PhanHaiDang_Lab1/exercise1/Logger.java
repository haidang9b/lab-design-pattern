import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.FileOutputStream;

public class Logger{
    private static Logger instance;
    private Logger(){

    }
    public static Logger getInstance(){
        if(instance == null){
            synchronized (Logger.class){
                if(instance == null){
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    public void LogMessage(String message){
        synchronized(this){
            try{

                FileOutputStream fos = new FileOutputStream("./log.txt", true);
                fos.write(message.getBytes());
                fos.close();
                // File file =new File("./log.txt");
                // FileWriter fileWritter = new FileWriter(file,true);
                // BufferedWriter bufferWritter = new BufferedWriter(fileWritter);
                // bufferWritter.write(message);
                // bufferWritter.close();
                // fileWritter.close();
            }
            catch (IOException ex){
                ex.printStackTrace();
            }
        }
        
    }
}