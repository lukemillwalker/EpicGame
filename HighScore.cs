using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Thing {
    class HighScore {

        //Strings that contain the file locations
        private String highScore  = @"highScore.txt";
        private String newHighScore = @"newHighScore.txt";
        private String backUpHighScore = @"backUpHighScore.txt";

        public HighScore() {
            try {
                //creates new high score file if it doesn't exist
                if (!File.Exists(highScore)) {
                    File.Create(highScore);
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Program broke down creating new files in the constructor");
            }
        }
        
        public String[] getHighScore(){

            String[] scores = new string[5];
            StreamReader reader;
            try {
                reader = new StreamReader(highScore);
                for(int i = 0; i < scores.Length; i++) {
                    if (reader.EndOfStream) {
                        scores[i] = "";
                    }
                    else scores[i] = reader.ReadLine();
                }

                reader.Close();
                reader.Dispose();
                Console.WriteLine("scores were returned");
                return scores;
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Program broke down returning the scores");
                return scores;
            }   
            
        }

        public void addScore(int score, String name) {

            try {
                //get length of high score file
                int length = fileLength();

                //create lists to store users
                List<User> users = new List<User>();

                //Initilizes files

                //creates reader to reader input from high score
                try {
                    StreamReader reader = new StreamReader(highScore);

                    //for loop to traverse through reader 
                    for (int i = 0; i < length; i++) {
                        String line = reader.ReadLine().Trim();
                        int CurrentScore = Int32.Parse(line.Substring(0, line.IndexOf(" ")));
                        String CurrentName = line.Substring(line.IndexOf(" ") + 1);
                        User currentUser = new User(CurrentScore, CurrentName);
                        users.Add(currentUser);
                    }

                    //finish getting all of user list together
                    User newUser = new User(score, name);
                    users.Add(newUser);
                    users.Sort();

                    //removes last user if list is greater than 5
                    if(users.Count > 5) {
                        users.RemoveRange(5, users.Count - 5);
                    }
                    //closes stream reader for high score file
                    reader.Close();
                }
                catch(IOException e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Broke adding stream reader");
                }
                //opens stream writer for new high score file
                StreamWriter writer = new StreamWriter(newHighScore);

                //for each element in users adds to writer
                foreach(User user in users){
                    writer.WriteLine(user);
                    Console.WriteLine(user);
                }

                writer.Flush();
                writer.Close();

                File.Replace(newHighScore, highScore, backUpHighScore);

            }

            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }

        //copys the new high score to the high score file
        

        //gets the number of lines in the high score file
        private int fileLength() {
            StreamReader reader = new StreamReader(highScore);
            int lines = 0;
            while (!reader.EndOfStream) {
                reader.ReadLine();
                lines++;
            }
            reader.Close();
            Console.WriteLine("File length is " + lines);
            return lines;

        }

        
    }
}
